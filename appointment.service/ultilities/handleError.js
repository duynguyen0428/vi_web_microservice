module.exports.sendError = (err,res)=>{
    return res.status(400).json({"message":"error occur"});
}