const db = require('../models');
const users = db.user;

exports.findAll = (req, res) => {
    users.findAll()
        .then(user => {
            res.status(200).send(user);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.findUser = (req, res) => {
    users.findAll({
        where: {
            id: req.params.id
        }
    })
        .then(user => {
            res.status(200).send(user);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}