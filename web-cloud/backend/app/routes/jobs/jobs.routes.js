module.exports = app => {
    const controller = require('../../controllers/jobs.controller');

    const router = require('express').Router();

    // Get all jobs
    router.get("/", controller.findAll);

    // Fetch data for a specific jobID
    router.get("/:jobID", controller.findJob);

    app.use('/api/jobs', router);
}