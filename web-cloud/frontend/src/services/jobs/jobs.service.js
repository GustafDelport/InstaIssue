import http from '../../http-common';

class JobsService {
    getAll() {
        return http.get(`/jobs/`);
    }

    get(id) {
        return http.get(`/jobs/${id}`)
    }
}

export default new JobsService();