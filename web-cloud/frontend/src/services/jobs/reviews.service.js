import http from '../../http-common';

class ReviewsService {
    create(data) {
        return http.post("/review/", data);
    }

    checkReviewed(jobID) {
        return http.get(`/review/check/${jobID}`);
    }

    getAll() {
        return http.get(`/review/`);
    }

    get(id) {
        return http.get(`/review/${id}`);
    }

    getClient(id) {
        return http.get(`/review/client/${id}`);
    }
}

export default new ReviewsService();