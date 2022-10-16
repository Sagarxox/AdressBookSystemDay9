using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contact> list = new List<Contact>();
        public void AddContact(Contact contact)
        {
            list.Add(contact);
            Display();
        }
        public void Display()
        {
            foreach (var contact in list)
            {
                Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zipcode: " + contact.Zip + "\n" + "Phone Number: " + contact.Phoneno + "\n" + "Email: " + contact.Email);
            }
        }
      
    }
}
