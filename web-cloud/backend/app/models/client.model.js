module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tblclients", {
        clientID: {
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
        nationalID: {
            type: Sequelize.STRING
        },
        phoneNumber: {
            type: Sequelize.STRING
        },
        email: {
            type: Sequelize.STRING
        },
        address: {
            type: Sequelize.STRING
        }
    },{
        tableName: 'tblclients'
    })
}