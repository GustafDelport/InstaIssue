import http from '../../http-common';

class UserService {
    get(id) {
        return http.get(`/users/${id}`);
    }

    getAll() {
        return http.get(`/users/`);
    }
}

export default new UserService();