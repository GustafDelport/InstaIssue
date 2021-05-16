module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tbljobs", {
        jobID: {
            type: Sequelize.STRING,
            primaryKey: true
        },
        clientID: {
            type: Sequelize.STRING
        },
        staffID: {
            type: Sequelize.STRING
        },
        scheduledDate: {
            type: Sequelize.DATE
        },
        service: {
            type: Sequelize.STRING
        },
        status: {
            type: Sequelize.STRING
        }
    },{
        tableName: 'tbljobs',
        timestamps: false
    })
}