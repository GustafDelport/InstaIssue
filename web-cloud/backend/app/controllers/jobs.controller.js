const db = require('../models');
const jobs = db.job;

exports.findAll = (req, res) => {
    jobs.findAll()
        .then(job => {
            res.status(200).send(job);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.findJob = (req, res) => {
    jobs.findAll({
        where: {
            jobID: req.params.jobID
        }
    })
        .then(job => {
            res.status(200).send(job);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}