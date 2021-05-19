module.exports = app => {
    const controller = require('../../controllers/staff.controller');

    const router = require('express').Router();

    // Get all staff
    router.get("/", controller.findAll);

    // Get all staff based on user ID
    router.get("/user/:id", controller.findStaffUser);

    // Get a specific staff member
    router.get("/:staffID", controller.findStaff);

    app.use('/api/staff', router);
}