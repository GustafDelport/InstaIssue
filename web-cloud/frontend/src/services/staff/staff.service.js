import http from '../../http-common';

class StaffService {
    get(id) {
        return http.get(`/staff/${id}`);
    }

    getAll() {
        return http.get(`/staff/`);
    }
}

export default new StaffService();