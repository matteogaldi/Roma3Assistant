const express = require("express");
const cookieParser = require("cookie-parser");
const logger = require("morgan");
require("dotenv").config();

const indexRouter = require("./routes/index");
const coursesRouter = require("./routes/courses");
const subscriptionsRouter = require("./routes/subscriptions");

const app = express();

app.use(logger("dev"));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());

app.use("/", indexRouter);
app.use("/corsi", coursesRouter);
app.use("/subscriptions", subscriptionsRouter);

module.exports = app;
