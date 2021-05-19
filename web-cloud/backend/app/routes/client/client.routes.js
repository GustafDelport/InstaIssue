module.exports = app => {
    const controller = require('../../controllers/client.controller');

    const router = require('express').Router();

    // Get all clients
    router.get("/", controller.findAll);

    // Get client based on userID
    router.get("/user/:id", controller.findClientUser);

    // Fetch data for a specific clientID
    router.get("/:clientID", controller.findClient);

    app.use('/api/client', router);
}