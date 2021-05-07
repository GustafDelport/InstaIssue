module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tbljobs", {
        jobID: {
            type: Sequelize.STRING,
            primaryKey: true
        },
        scheduledDate: {
            type: Sequelize.DATE
        },
        service: {
            type: Sequelize.STRING
        },
        status: {
            type: Sequelize.STRING
        },
        staffID: {
            type: Sequelize.STRING
        }
    },{
        tableName: 'tbljobs'
    })
}