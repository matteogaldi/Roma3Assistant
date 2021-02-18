const express = require("express");
const router = express.Router();
const db = require("../services/database");
const authMiddleware = require("../services/auth");

const getTeachers = async (req, res, next) => {
  req.data = await db.teachers.findMany();
  next();
};

const getTeacherByID = async (req, res, next) => {
  req.data = await db.teachers.findUnique({
    where: {
      id: req.params.teacherID,
    },
    include: {
      courses: {
        select: {
          id: true,
          name: true,
          code: true,
          partition: true,
        },
      },
    },
  });
  next();
};

router.post("/", authMiddleware, getTeachers, (req, res) => {
  res.json(req.data);
});

router.post("/:teacherID", authMiddleware, getTeacherByID, (req, res) => {
  res.json(req.data);
});

module.exports = router;
