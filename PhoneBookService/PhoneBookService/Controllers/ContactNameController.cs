using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookService.Models;

namespace PhoneBookService.Controllers
{
    [Route("contact-by-name")]
    [ApiController]
    public class ContactNameController : ControllerBase
    {
        [HttpGet(Name = "GetContactViaName")]
        public Contact? Get(string Name) 
        {
            Contact? c = PhoneBook.MyPhoneBook.Find((Contact contact) => {
                if (contact.Name == Name)
                {
                    return true;
                }
                return false;
            });

            return c;
        }
            
    }
}
