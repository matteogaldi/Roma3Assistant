const express = require("express");
const router = express.Router();
const db = require("../services/database");
const authenticateMiddleware = require("../services/auth");

const getUserIdByEmail = async (req, res, next) => {
  req.data = await db.students.findUnique({
    where: {
      email: req.body.email,
    },
  });
};

router.get("/", authenticateMiddleware, getUserIdByEmail, (req, res) => {
  res.json(req, data);
});

module.exports = router;
