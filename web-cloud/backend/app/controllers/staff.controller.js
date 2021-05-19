const db = require('../models');
const users = db.staff;

exports.findAll = (req, res) => {
    users.findAll()
        .then(staff => {
            res.status(200).send(staff);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.findStaff = (req, res) => {
    users.findAll({
        where: {
            staffID: req.params.staffID
        }
    })
        .then(staff => {
            res.status(200).send(staff);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.findStaffUser = (req, res) => {
    users.findAll({
        where: {
            userID: req.params.id
        }
    })
        .then(staff => {
            res.status(200).send(staff);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}