var httpServer = require('http');
var app = require('express')();
var config = require('./config/config');
var bodyParser = require("body-parser");
var port = config.config.port;
var emailService = require('./service.repository/emailservice');

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

app.post("/api/confirmemail",(req,res)=>{
    var recpt = req.body.repct;
    var content = req.body.content;
    var subject = req.body.sub;

    emailService.sendEmail(recpt,subject,content);
    res.status(200).json({"message":"sent"});
});

var server = httpServer.createServer(app);
server.listen(port,() => {
    console.log("listenning on port " + port);
})