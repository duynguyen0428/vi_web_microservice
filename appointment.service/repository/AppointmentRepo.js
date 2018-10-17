var AppointmentModel = require('../model/Appointment');

module.exports.FindAllAppt = (cb)=>{
    AppointmentModel.find({},(err,appts)=>{
        if(!err) cb(null,appts);
    })
}

module.exports.AddAppt = (title,date,cb) => {
    AppointmentModel.create({Title:title,Date:date},(err,appt)=>{
        console.log(err);
        if(!err) cb(null,appt);
    })
}

module.exports.FindbyDate = (date, cb) => {
    AppointmentModel.find({Date:date}).exec((err,res)=>{
        if (!err) cb(null,res);
    });
}