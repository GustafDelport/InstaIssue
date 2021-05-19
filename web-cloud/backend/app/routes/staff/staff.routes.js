module.exports = app => {
    const controller = require('../../controllers/staff.controller');

    const router = require('express').Router();

    // Get all staff
    router.get("/", controller.findAll);

    // Get a specific staff member
    router.get("/:staffID", controller.findStaff);

    app.use('/api/staff', router);
}