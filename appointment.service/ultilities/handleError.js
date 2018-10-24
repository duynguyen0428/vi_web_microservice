module.exports.sendError = (err,res)=>{
    console.error('Error Details: \n' + err);
    var return_code = 500;
    var return_message = {message:'Internal Error'};
    // if(typeof err === ValidationError){
    //     return_message.message = 'Request Error';
    //     return_code = 400;
    // }
    return res.status(return_code).json(return_message);
}