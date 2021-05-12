module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tblreviewRecords", {
        reviewID: {
            type: Sequelize.STRING,
            primaryKey: true
        },
        clientID: {
            type: Sequelize.STRING
        },
        Timestamp: {
            type: Sequelize.DATE
        },
        rating: {
            type: Sequelize.FLOAT
        },
        description: {
            type: Sequelize.STRING
        },
        staffID: {
            type: Sequelize.STRING
        },
        jobID: {
            type: Sequelize.STRING
        }
    },{
        tableName: 'tblreviewRecords'
    })
}