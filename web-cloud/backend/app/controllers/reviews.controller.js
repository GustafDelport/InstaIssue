const db = require('../models');
const reviews = db.review;

const { customAlphabet } = require('nanoid');
const nanoid = customAlphabet('1234567890abcdef', 10);

exports.create = async (req, res) => {
    if (req.body.jobID) {
        await reviews.create({
            reviewID: nanoid(),
            clientID: req.body.clientID,
            Timestamp: req.body.Timestamp,
            rating: req.body.rating,
            description: req.body.description,
            staffID: req.body.staffID,
            jobID: req.body.jobID
        }).then(data => {
            res.status(200).send(data);
        }).catch(err => {
            res.status(500).send({
                message:
                    err.message || "Internal Server Error. Something went wrong while saving the post in the database."
            });
        })
    } else {
        res.status(500).send({
            message: "No jobID specified!"
        });
    }

}

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

exports.findReviewClient = (req, res) => {
    reviews.findAll({
        where: {
            clientID: req.params.clientID
        }
    })
        .then(review => {
            res.status(200).send(review);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.checkReviewed = (req, res) => {
    reviews.findAll({
        where: {
            jobID: req.params.jobID
        }
    })
        .then(review => {
            res.status(200).send(review);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}