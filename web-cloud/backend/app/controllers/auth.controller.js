const config = require('../config/auth.config');
const db = require('../models');
const User = db.user;

const Op = db.Sequelize.Op;

const jwt = require('jsonwebtoken');

exports.signin = (req, res) => {
    User.findOne({
        where: {
            username: req.body.username
        }
    })
        .then(user => {
            if (!user) {
                return res.status(404).send({ message: "User Not found." });
            }

            const passwordIsValid = req.body.password === user.password;

            if (!passwordIsValid) {
                return res.status(401).send({
                    accessToken: null,
                    message: "Invalid Password!"
                });
            }

            let token = jwt.sign({ id: user.id }, config.secret, {
                expiresIn: 86400 // 24 Hours
            });

            console.log(user)

            res.status(200).send({
                id: user.id,
                username: user.username,
                createdAt: user.createdAt,
                updatedAt: user.updatedAt,
                accessToken: token
            });
        })
        .catch(err => {
            res.status(500).send({ message: err.message });
        });
};