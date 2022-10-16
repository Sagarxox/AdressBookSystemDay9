using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            AddressBook address = new AddressBook();


            Console.WriteLine("Please Enter the details");
        

                        Console.WriteLine("--------------------------");
                        Console.Write("first name :");
                        contact.FirstName = Console.ReadLine();
                        Console.Write("last name :");
                        contact.LastName = Console.ReadLine();
                        Console.Write("Address :");
                        contact.Address = Console.ReadLine();
                        Console.Write("City :");
                        contact.City = Console.ReadLine();
                        Console.Write("State :");
                        contact.State = Console.ReadLine();
                        Console.Write("ZipCode :");
                        contact.ZipCode = (Console.ReadLine());
                        Console.Write("PhoneNo :");
                        contact.PhoneNumber = Console.ReadLine();
                        Console.Write("Email :");
                        contact.Email = Console.ReadLine();
                    
                    Console.WriteLine("Display contact detail:");
            Console.WriteLine("\n-------------------------------------\n");
                    address.AddContact(contact);
                   
             



            
        }
    }
}
