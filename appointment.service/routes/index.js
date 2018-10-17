var express = require('express');
var router = express.Router();
var appointmentRoute = require('./api/appointment.route')

/* GET home page. */
router.use("/api/appointment", appointmentRoute);

router.get('/', function(req, res, next) {
  res.render('index', { title: 'Express' });
});

module.exports = router;
