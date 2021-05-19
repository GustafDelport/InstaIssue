module.exports = app => {
    const controller = require('../../controllers/user.controller');

    const router = require('express').Router();

    // Get all users
    router.get("/", controller.findAll);

    // Get all jobs for a specific client
    router.get("/:id", controller.findUser);

    app.use('/api/users', router);
}