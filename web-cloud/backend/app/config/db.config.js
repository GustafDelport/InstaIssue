module.exports = {
    HOST: process.env.DB_HOST || "localhost",
    PORT: process.env.DB_PORT || "1433",
    USER: process.env.DB_USER || "User1",
    PASSWORD: process.env.DB_PASSWORD || "password",
    DB: process.env.DB || "instaissue",
    dialect: process.env.DB_DIALECT || "mssql",
    operatorsAliases: false,
    pool: {
        max: 5,
        min: 0,
        acquire: 30000,
        idle: 10000
    }
};