const express = require("express");
const router = express.Router();
const db = require("../services/database");
const jwt = require("jsonwebtoken");

const token = async (req, res) => {
  const user = await db.students.findUnique({ where: { id: req.body.uuid } });
  if (user == null) {
    res.sendStatus(401);
    return;
  } else {
    jwt.sign({ id: user.id }, "testSecret", (err, token) => {
      if (err) res.sendStatus(500);
      else
        res.json({
          success: true,
          user: user,
          token,
        });
    });
  }
};

router.post("/", token, (req, res) => {
  res.end();
});

module.exports = router;
