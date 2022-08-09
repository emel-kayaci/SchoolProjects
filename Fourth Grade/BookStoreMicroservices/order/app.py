from flask import Flask
from routes import order_blueprint
from models import db, init_app
from flask_migrate import Migrate
app = Flask(__name__)

@app.before_first_request
def create_tables():
    db.create_all()

app.config['SECRET_KEY'] = 'duH32e3AkTgoTyk7TiO3NA'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///./database/order.db'


app.register_blueprint(order_blueprint)
init_app(app)
migrate = Migrate(app, db)

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=5003)