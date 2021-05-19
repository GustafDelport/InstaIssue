module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tblstaff", {
        staffID: {
            type: Sequelize.STRING,
            primaryKey: true
        },
        userID: {
            type: Sequelize.STRING
        },
        name: {
            type: Sequelize.STRING
        },
        surname: {
            type: Sequelize.STRING
        },
        status: {
            type: Sequelize.STRING
        },
        skills: {
            type: Sequelize.STRING
        },
        address: {
            type: Sequelize.STRING
        }
    },{
        tableName: 'tblstaff',
        timestamps: false
    })
}