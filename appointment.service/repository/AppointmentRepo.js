var AppointmentModel = require('../model/Appointment');

module.exports.FindAllAppt = (cb)=>{
    AppointmentModel.find({}).then((appts)=>{
        cb(null,appts);
    }).catch(err => cb(err));
}

module.exports.AddAppt = (title,date,cb) => {
    AppointmentModel.create({Title:title,Date:date}).then((err,appt)=>{
        cb(null,appt);
    }).catch(err => cb(err));
}

module.exports.FindbyDate = (date, cb) => {
    AppointmentModel.find({Date:date}).exec().then((res)=>{
            cb(null,res);
    }).then(err=> cb(err));
}