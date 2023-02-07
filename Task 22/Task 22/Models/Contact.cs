using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Task_22.Models
{
    public class Contact
    {
       
        [Key]
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Contact(string name, string phoneNumber,  string address)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }

        // ToString
        public override string ToString()
        {
            return "\t______\n\t Contact Details: " + "\n\t Name: " + Name + "\n\t Phone Number : " + PhoneNumber + "\n\t : Current Address" + Address + "\n\t______";
        }
    }
}
