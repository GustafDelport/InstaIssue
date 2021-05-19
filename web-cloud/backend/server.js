const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');

const app = express();

const corsOptions = {
    origin: process.env.ORIGIN || "http://localhost:3000"
};

// Enable CORS
app.use(cors(corsOptions));

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
require('./app/routes/user/user.routes')(app);
require('./app/routes/staff/staff.routes')(app);

// Set port & listen for requests
const PORT = process.env.PORT || 8080;
app.listen(PORT, () => {
    console.log(`API is running on port ${PORT}.`);
});