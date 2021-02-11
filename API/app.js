const express = require("express");
const cookieParser = require("cookie-parser");
const logger = require("morgan");
const helmet = require("helmet");
require("dotenv").config();

const coursesRouter = require("./routes/courses");
const subscriptionsRouter = require("./routes/subscriptions");
const userRouter = require("./routes/user");
const tokenRouter = require("./routes/token");
const teachersRouter = require("./routes/teachers");

const app = express();
app.use(helmet());

app.use(logger("dev"));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());

app.use("/courses", coursesRouter);
app.use("/subscriptions", subscriptionsRouter);
app.use("/user", userRouter);
app.use("/auth/login", tokenRouter);
app.use("/teachers", teachersRouter);

module.exports = app;
