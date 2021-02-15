const express = require("express");
const router = express.Router();
const db = require("../services/database");
const authMiddleware = require("../services/auth");

const setSubscription = async (req, res, next) => {
  req.data = await db.subscriptions
    .create({
      data: {
        student: req.body.studentUUID,
        course: req.body.courseUUID,
      },
    })
    .catch((err) => {
      res.sendStatus(500);
      console.error(err);
    });
  next();
};

const getSubscriptions = async (req, res, next) => {
  const subs = await db.subscriptions
    .findMany({
      where: {
        student: `${req.body.uuid}`,
      },
      select: {
        course: true,
      },
    })
    .catch((err) => {
      console.error("Catching error");
      res.sendStatus(400);
      res.end();
    });

  if (subs != undefined) {
    req.data = [];
    subs.map(({ course }) => req.data.push(course));
  }
  next();
};

router.put("/", authMiddleware, setSubscription, (req, res) => {
  res.json(req.data);
  res.end();
});

router.post("/", authMiddleware, getSubscriptions, (req, res) => {
  res.json(req.data).end();
});

module.exports = router;
