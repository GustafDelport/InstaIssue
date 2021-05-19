const config = require('../config/db.config');

const Sequelize = require('sequelize');
const sequelize = new Sequelize(
    config.DB,
    config.USER,
    config.PASSWORD,
    {
        enableArithAbort: true,
        dialect: config.dialect,
        host: config.HOST,
        port: config.PORT,
        pool: {
            max: config.pool.max,
            min: config.pool.min,
            acquire: config.pool.acquire,
            idle: config.pool.idle
        },
    }
);

const db = {};

db.Sequelize = Sequelize;
db.sequelize = sequelize;

// Data Models
db.user = require('../models/user.model')(sequelize, Sequelize);
db.job = require('../models/jobs.model')(sequelize, Sequelize);
db.review = require('../models/reviews.model')(sequelize, Sequelize);
db.client = require('../models/client.model')(sequelize, Sequelize);
db.staff = require('../models/staff.model')(sequelize, Sequelize);

module.exports = db;