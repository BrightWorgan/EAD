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
            // Using a predicate function (lambda)
            //Predicate<Contact> contactLambda = (Contact contact) =>
            //{
            //    if (contact.Name == Name)
            //    {
            //        return true;
            //    }
            //    return false;
            //};
            //Contact? c = PhoneBook.MyPhoneBook.Find(contactLambda);

            // Shorthand for the above without needing to define a separate variable
            //Contact? c = PhoneBook.MyPhoneBook.Find((Contact contact) => {
            //    if (contact.Name == Name)
            //    {
            //        return true;
            //    }
            //    return false;
            //});

            // Non linq way
            foreach (var contact in PhoneBook.MyPhoneBook)
            {
                if (contact.Name == Name)
                {
                    return contact;
                }
            }
            return null;
        }
            
    }
}
