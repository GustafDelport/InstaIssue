import http from '../../http-common';

class ClientService {
    get(id) {
        return http.get(`/client/${id}`);
    }

    getClient(userID) {
        return http.get(`/client/user/${userID}`);
    }

    getAll() {
        return http.get(`/client/`);
    }
}

export default new ClientService();