using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {

        public static void Main()
        {

            Person a = new Person();

            {

                a.FirstName = "sagar";
                a.LastName = "kumar";
                a.PhoneNumber = "1234567890";
                    a.Address = "durg cg";
                a.City = "durg";
                a.State = "CG";
                a.ZipCode = "456770";
                a.Email = "drytd@gmail.com";


                Console.WriteLine(" FirstName :" + a.FirstName + "\n LastName :" + a.LastName + "\n Phone number :" + a.PhoneNumber + "\n Address :" + a.Address + "\nCity :" + a.City + "\n State :" + a.State + "\n Zip code : " + a.ZipCode + "\n Email :" + a.Email);


            }
        }

    }
}
