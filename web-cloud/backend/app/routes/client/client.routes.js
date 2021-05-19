module.exports = app => {
    const controller = require('../../controllers/client.controller');

    const router = require('express').Router();

    // Get all clients
    router.get("/", controller.findAll);

    // Fetch data for a specific clientID
    router.get("/:clientID", controller.findClient);

    app.use('/api/client', router);
}