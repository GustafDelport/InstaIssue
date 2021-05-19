module.exports = app => {
    const controller = require('../../controllers/reviews.controller');

    const router = require('express').Router();

    // Get all unreviewed jobs
    //router.get("/unreviewed", controller.findUnreviewed);

    // Get all reviewed
    router.get("/", controller.findReviewed);

    // Fetch data for a specific reviewID
    router.get("/:reviewID", controller.findReview);

    app.use('/api/review', router);
}