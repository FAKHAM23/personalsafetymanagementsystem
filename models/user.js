const mongoose = require("mongoose");

const userSchema = new mongoose.Schema(
  {
    // username, password, first name, last name, date of birth (DOB), and role (Admin, Super User).
    userName: String,
    password: String,
    firstName: String,
    lastName: String,
    dateOfBirth: Date ,
    role: String
  },
  { timestamps: true }
);

module.exports = mongoose.model("User", userSchema);
