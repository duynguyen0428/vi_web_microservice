var router = require('express').Router();
var appointmentRepo = require('../../repository/AppointmentRepo');

router.get('/',(req,res) => {
    var appt = appointmentRepo.FindAllAppt((err,appts)=>{
        if(!err) res.status(200).json(appts);
    })
})
.post('/',(req,res) => {
    appointmentRepo.AddAppt(req.body.title,req.body.date,(err)=>{
        console.log(err);
        if(!err) res.status(201).json({"message":"success"});
    })
});

module.exports = router;