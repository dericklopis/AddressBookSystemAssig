using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemAssig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;
            Contact person = new Contact();
            while (choice)
            {
                Console.WriteLine("Enter 1 for Add Contact\n" +
                    "Enter 2 for Edit contact\n" +
                    "Enter 3 for Remove contact\n" +
                    "Enter 4 for Display Details\n" +
                    "Enter 5 for create Dict\n" +
                    "Enter 6 for Display dict\n" +
                    "Enter 7 for exit");
                int x;
                x=Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        person.addcontact();
                        break;
                    case 2:
                        person.EditContact();
                        break;
                    case 3:
                        person.RemoveDetails();
                        break;
                    case 4:
                        person.displayDetails();
                        break;
                    case 5:
                        person.CreateDict();
                        break;
                    case 6:
                        person.DisplayDict();
                        break;

                    default:
                        choice=false;
                        break;

                }
            }
            //person.addcontact();
            //person.addcontact();
            //person.EditContact();
            //person.RemoveDetails();
            //person.displayDetails();
            //person.CreateDict();
        }
    }
}

