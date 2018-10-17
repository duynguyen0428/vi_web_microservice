var mailer = require("nodemailer");
var xoauth2 = require('xoauth2');

var email = require("emailjs/email");
function sendemail() {
    // Use Smtp Protocol to send Email
    var smtpTransport = mailer.createTransport({
        service: "gmail",
        auth: {
                user: "@gmail.com",
                pass: "xxxxxxx"
        }
    });

    var mail = {
        from: "Duy Nguyen <@gmail.com>",
        to: "@yahoo.com",
        subject: "Send Email Using Node.js",
        text: "Node.js New world for me",
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