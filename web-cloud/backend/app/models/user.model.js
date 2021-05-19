module.exports = (sequelize, Sequelize) => {
    return sequelize.define("tblusers", {
        id: {
            type: Sequelize.INTEGER,
            primaryKey: true
        },
        username: {
            type: Sequelize.STRING
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