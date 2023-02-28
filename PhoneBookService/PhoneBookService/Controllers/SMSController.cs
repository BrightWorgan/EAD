using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookService.Models;
using System.Reflection.Metadata.Ecma335;

namespace PhoneBookService.Controllers
{
    [Route("contact-by-name")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        private const string LOGFILENAME = "c:\\temp\\Lab3TextMessages.txt";

        [HttpPost(Name = "Send SMS")]
        public void Post(SMSMessage msg)
        {
            if (ModelState.IsValid)
            {
                log("Sent: " + msg);
                //return (IHttpActionResult)Ok();
            }
            else
            {
                //return (IHttpActionResult)BadRequest();
            }
        }

        private void log(string logText)
        {
            try
            {
                StreamWriter logWriter = new StreamWriter(LOGFILENAME, true);
                logWriter.Write(logText);
                logWriter.WriteLine(" " + DateTime.Now);
                logWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}