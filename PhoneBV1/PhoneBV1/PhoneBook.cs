using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBV1
{
    public class PhoneBook
    {
        // fields phoneNumber, Name, Address
        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // constructor
        public PhoneBook(string PhoneNum, string Name, string Address)
        {
            this.PhoneNum = PhoneNum;
            this.Name = Name;
            this.Address = Address;
        }

        // ToString()
        public override string ToString()
        {
            return("\n\t_____" + "\n\tPhone Number: " + PhoneNum + "Phone Number: " + Name + "Name: " + Address + "Address: " + "\n\t_____");
        }

    }
}
