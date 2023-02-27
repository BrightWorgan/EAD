using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookService.Models;

namespace PhoneBookService.Controllers
{
    [Route("contact-by-name")]
    [ApiController]
    public class ContactNumController : ControllerBase
    {

        [HttpGet(Name = "GetContactViaPhoneNumber")]
        public Contact? Get(string PhoneNumber) 
        {
            // Non linq way
            foreach (var contact in PhoneBook.MyPhoneBook)
            {
                if (contact.PhoneNumber == PhoneNumber)
                {
                    return contact;
                }
            }
            return null;
        }
            
    }
}
