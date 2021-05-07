module.exports = app => {
    const controller = require('../../controllers/auth.controller');

    const router = require('express').Router();

    app.use((req, res, next) => {
        res.header(
            "Access-Control-Allow-Headers",
            "x-access-token, Origin, Content-Type, Accept"
        );
        next();
    });

    // Sign-in
    router.post('/signin', controller.signin);

    app.use('/api/auth', router);
}