const express = require("express");
const router = express.Router();
const db = require("../services/database");

const getCourses = async (req, res, next) => {
  req.data = await db.courses.findMany({
    include: {
      teachers: true,
    },
  });

  next();
};

const getCourseInfo = async (req, res, next) => {
  const course = await db.courses.findUnique({
    where: {
      id: req.params.courseID,
    },
    include: {
      teachers: true,
    },
  });
  req.data = course;
  next();
};

router.get("/", getCourses, (req, res) => {
  res.send(req.data);
});

router.get("/:courseID", getCourseInfo, (req, res) => {
  res.json(req.data);
});

module.exports = router;
