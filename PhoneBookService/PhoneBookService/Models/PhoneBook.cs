namespace PhoneBookService.Models
{
    public static class PhoneBook
    {
        public static List<Contact> MyPhoneBook = new List<Contact>();

        public static void init()
        {
            Contact c1 = new Contact() { Address = "Home", Name = "Sarah", PhoneNumber = "808555555"};
            MyPhoneBook.Add(c1);
            Contact c2 = new Contact() { Address = "Forest", Name = "Skadi", PhoneNumber = "808555566" };
            MyPhoneBook.Add(c2);
            Contact c3 = new Contact() { Address = "Valhalla", Name = "Zeus", PhoneNumber = "808555577" };
            MyPhoneBook.Add(c3);
        }
    }
}
