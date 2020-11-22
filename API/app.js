const express = require("express");
const cookieParser = require("cookie-parser");
const logger = require("morgan");
require("dotenv").config();

const coursesRouter = require("./routes/courses");
const subscriptionsRouter = require("./routes/subscriptions");

const app = express();

app.use(logger("dev"));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());

app.use("/courses", coursesRouter);
app.use("/subscriptions", subscriptionsRouter);

module.exports = app;
