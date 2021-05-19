const db = require('../models');
const clients = db.client;

exports.findAll = (req, res) => {
    console.log('Find all called of clients')
    clients.findAll()
        .then(client => {
            res.status(200).send(client);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}

exports.findClient = (req, res) => {
    clients.findAll({
        where: {
            clientID: req.params.clientID
        }
    })
        .then(client => {
            res.status(200).send(client);
        })
        .catch(e => {
            res.status(500).send({ message: e.message });
        })
}