var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var AppointmentSchema = Schema({
    Title:{
        type: String,
        required: [true,"Title can not be blank"]
    },
    Created : {
        type: Date,
        default: Date.now()
    },
    Date : {
        type: Date,
        required: [true, "Date can't be none"]
    }
});

var Appointment = mongoose.model("Appointment", AppointmentSchema)

module.exports = Appointment;