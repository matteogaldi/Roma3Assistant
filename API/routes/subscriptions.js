const mysql = require("mysql");
const express = require("express");
const router = express.Router();
const db = require("../services/database");

const setSubscription = (req, res, next) => {
  db.getConnection((err, connection) => {
    if (err) throw err;
    const sqlString =
      "INSERT INTO Subscriptions(id, course, student) VALUES (uuid(), ?, ?)";
    const sql = mysql.format(sqlString, [req.body.courseID, req.body.userID]);
    connection.query(sql, (err, result) => {
      if (err) {
        res.status(500);
      }
      connection.release();
      res.status(200);
      next();
    });
  });
};

const getSubscription = (req, res, next) => {
  db.getConnection((err, connection) => {
    if (err) throw err;
    const sqlString = "SELECT course FROM Subscriptions WHERE student = ?";
    const sql = mysql.format(sqlString, [req.body.userID]);
    connection.query(sql, (err, result) => {
      if (err) throw err;
      req.data = result;
      connection.release;
      next();
    });
  });
};

router.post("/", setSubscription, (req, res) => {
  res.end();
});

router.get("/", getSubscription, (req, res) => {
  res.json(req.data).end();
});

module.exports = router;
