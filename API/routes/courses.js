const express = require("express");
const router = express.Router();
const db = require("../services/database");

const getCourses = (req, res, next) => {
  db.getConnection((err, connection) => {
    const sql = "SELECT * FROM Courses";
    connection.query(sql, (err, results) => {
      req.data = results;
      connection.release();
      next();
    });
  });
};

router.get("/", getCourses, (req, res) => {
  res.send(req.data);
});

module.exports = router;
