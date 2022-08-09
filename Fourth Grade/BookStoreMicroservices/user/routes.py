from flask import Blueprint, jsonify, request, make_response
from models import db, User
from flask_login import login_user, current_user, logout_user
from werkzeug.security import generate_password_hash, check_password_hash

user_blueprint = Blueprint('user_api_routes', __name__, url_prefix='/api/user')


@user_blueprint.route('/all', methods=['GET'])
def get_all_users():
    all_users = User.query.all()
    # Convert all users to json format
    result = [user.serialize() for user in all_users]
    response = {
        'message': 'Returning all users',
        'result': result
    }
    return jsonify(response)


@user_blueprint.route('/create', methods=['POST'])
def create_user():
    try:
        user = User()
        user.username = request.form["username"]
        user.password = generate_password_hash(request.form['password'], method='sha256')
        user.is_admin=True
        db.session.add(user)
        db.session.commit()

        response = {'message': 'User Created', 'result': user.serialize()}
    except Exception as e:
        print(str(e))
        response = {'message': 'Error in creating response'}
    return jsonify(response)

@user_blueprint.route('/login', methods=['POST'])
def login():
    username = request.form['username']
    password = request.form['password']

    # Check if user exists in database
    user = User.query.filter_by(username=username).first()
    if not user:
        response = {'message': 'username does not exists'}
        return make_response(jsonify(response), 401)
    if check_password_hash(user.password, password):
        # If user is logged in generate API key
        user.update_api_key()
        # Save changes to database
        db.session.commit()
        login_user(user)
        response = {'message': 'logged in', 'api_key': user.api_key}
        return make_response(jsonify(response), 200)

    response = {'message': 'Access denied'}
    return make_response(jsonify(response), 401)

@user_blueprint.route('/logout', methods=['POST'])
def logout():
    if current_user.is_authenticated:
        logout_user()
        return jsonify(({'message': 'logged out'}))
    return jsonify({'message': 'No user logged in'}), 401

@user_blueprint.route('/<username>/exists', methods=['GET'])
def user_exists(username):
    user = User.query.filter_by(username=username).first()
    if user:
        return jsonify({"result":True}), 200
    return jsonify({"result":False}), 404

@user_blueprint.route('/', methods=['GET'])
def get_current_user():
    if current_user.is_authenticated:
        return jsonify({'result': current_user.serialize()}), 200
    else:
        return jsonify({'message': 'User not logged in'}), 401
