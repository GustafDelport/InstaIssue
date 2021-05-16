const db = require('../models');
const reviews = db.review;

exports.findReviewed = (req, res) => {
    reviews.findAll()
        .then(review => {
            res.status(200).send(review);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.findReview = (req, res) => {
    reviews.findAll({
        where: {
            reviewID: req.params.reviewID
        }
    })
        .then(review => {
            res.status(200).send(review);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}