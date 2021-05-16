const express = require('express');
const bodyParser = require('body-parser');

const app = express();

// Parse requests of content-type - application/json
app.use(bodyParser.json());

// Parse requests of content-type - application/json
app.use(bodyParser.urlencoded({ extended: true }));

const db = require('./app/models');

// Used for deployments
db.sequelize.sync();

// Base route
app.get("/", (req, res) => {
    res.json({ message: "Welcome to the backend API!" });
});

// Routes
require('./app/routes/authentication/auth.routes')(app);
require('./app/routes/client/client.routes')(app);
require('./app/routes/jobs/jobs.routes')(app);
require('./app/routes/jobs/reviews.routes')(app);

// Set port & listen for requests
const PORT = process.env.PORT || 8080;
app.listen(PORT, () => {
    console.log(`API is running on port ${PORT}.`);
});