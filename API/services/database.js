const db = require("mysql");

const conn = db.createPool({
  host: process.env.DB_HOST,
  user: process.env.DB_USER,
  password: process.env.DB_PASSWORD,
  database: "app",
});

module.exports = conn;
