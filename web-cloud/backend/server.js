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
// = Call routes from routes directory

// Set port & listen for requests
const PORT = process.env.PORT || 8080;
app.listen(PORT, () => {
    console.log(`API is running on port ${PORT}.`);
});