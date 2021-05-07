module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tblusers", {
        username: {
            type: Sequelize.STRING,
            primaryKey: true
        },
        password: {
            type: Sequelize.STRING
        },
        createdAt: {
            type: Sequelize.DATE
        },
        updatedAt: {
            type: Sequelize.DATE
        }
    },{
      tableName: 'tblusers'
    })
}