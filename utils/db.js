const mongose = require("mongoose");
mongose.set("strictQuery", true);

mongose.connect("mongodb://localhost:27017/express", {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});

const db = mongose.connection;

db.on("error", (err) => {
  console.log(err);
});
db.once("open", () => {
  console.log("Database connection established");
});