from flask import Flask
from flask.sessions import SecureCookieSessionInterface
from routes import user_blueprint
from flask_migrate import Migrate
from flask_login import LoginManager
import models

app = Flask(__name__)
# From secrets module use token_url_safe(16) method to generate random secret key
app.config['SECRET_KEY'] = '_xYtM8dz9w_p41B460Xsjg'
# Connection string to the database (in current directory)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///./database/user.db'
models.init_app(app)

# Blueprint for routes.py
app.register_blueprint(user_blueprint)
login_manager = LoginManager(app)

# Default code for login manager
@login_manager.user_loader
def load_user(user_id):
    return models.User.query.filter_by(id=user_id).first()

# Default code for login manager
@login_manager.request_loader
def load_user_from_request(request):
    api_key = request.headers.get('Authorization')
    if api_key:
        api_key = api_key.replace('Basic ', '', 1)
        user = models.User.query.filter_by(api_key=api_key).first()
        if user:
            return user
    return None

# Default code for login manager
class CustomSessionInterface(SecureCookieSessionInterface):
    """Prevent creating session from API requests."""
    def save_session(self, *args, **kwargs):
        if g.get('login_via_request'):
            return
        return super(CustomSessionInterface, self).save_session(*args,
                                                                **kwargs)

migrate = Migrate(app, models.db)
if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5001)
