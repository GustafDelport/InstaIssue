import http from '../../http-common';

class ClientJobsService {
    get(id) {
        return http.get(`/jobs/client/${id}`);
    }
}

export default new ClientJobsService();