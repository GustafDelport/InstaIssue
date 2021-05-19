module.exports = app => {
    const controller = require('../../controllers/reviews.controller');

    const router = require('express').Router();

    // Get all unreviewed jobs
    //router.get("/unreviewed", controller.findUnreviewed);

    // Insert Review
    router.post("/", controller.create);

    // Get all reviewed
    router.get("/", controller.findReviewed);

    // Check if job has been reviewed
    router.get("/check/:jobID", controller.checkReviewed);

    // Get all reviewed for specific client
    router.get("/client/:clientID", controller.findReviewClient);

    // Fetch data for a specific reviewID
    router.get("/:reviewID", controller.findReview);

    app.use('/api/review', router);
}