const express = require('express'),
    app = express(),
    bodyParser = require("body-parser"),
    port = 3000;

const indexRoutes = require('./routes/index');

app.use(bodyParser.urlencoded({
    extended: true
}));

app.set("view engine", "ejs");
app.use(express.static(__dirname + "/public"));

app.use(indexRoutes);

app.listen(port, () => console.log(`App started on port ${port}`));