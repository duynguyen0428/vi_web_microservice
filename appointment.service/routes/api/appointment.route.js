var router = require('express').Router();
var appointmentRepo = require('../../repository/AppointmentRepo');
var handlerError = require('../../ultilities/handleError');
router.get('/',(req,res) => {
    appointmentRepo.FindAllAppt((err,appts)=>{
        if(!err) res.status(200).json(appts);
        else { 
            handlerError.sendError(err,res);
        }
    })
})
.get('/:scheduledate',(req,res)=>{
    var scheduledate = req.params.scheduledate;
    appointmentRepo.FindbyDate(scheduledate,(err,appts)=>{
        if(err) handlerError(err,res);
        else res.status(200).json(appts);
    });
})
.post('/',(req,res) => {
    appointmentRepo.AddAppt(req.body.title,req.body.date,(err)=>{
       
        if(!err) res.status(201).json({"message":"success"});
        else{
            handlerError.sendError(err,res);
        }
    })
});

module.exports = router;
