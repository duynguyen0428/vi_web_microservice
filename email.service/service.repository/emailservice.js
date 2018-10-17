var mailer = require("nodemailer");
var xoauth2 = require('xoauth2');

var email = require("emailjs/email");
const config = require('../config/credential');

module.exports.sendEmail = function sendemail(recepient,subject,content) {
    // Use Smtp Protocol to send Email
    var smtpTransport = mailer.createTransport({
        service: "gmail",
        auth: {
                user: config.credentials.username,
                pass: config.credentials.access_password
        }
    });

    var mail = {
        from: "no-rely <no-reply@mail.com>",
        to: recepient,
        subject: subject,
        text: content,
        html: "<b>Node.js New world for me</b>"
    }

    smtpTransport.sendMail(mail, function (error, response) {
        if (error) {
            console.log(error);
        } else {
            console.log("Message sent: " + response.message);
        }

        smtpTransport.close();
    });

    // var server = email.server.connect({
    //     user: "duynguyen0428",
    //     password: "krliaqlbhzqhwcyx",
    //     host: "smtp.gmail.com",
    //     ssl: true
    // });

    // // send the message and get a callback with an error or details of the message that was sent
    // server.send({
    //     text: "i hope this works",
    //     from: "you <duynguyen0428@gmail.com>",
    //     to: "someone <dylan2728@yahoo.com>",
    //     subject: "testing emailjs"
    // }, function (err, message) { console.log(err || message); });
}

sendemail();