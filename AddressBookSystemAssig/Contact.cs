using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemAssig
{
    class Contact
    {
        List<Person> person1 = new List<Person>();
        Dictionary<string, List<Person>> person2 = new Dictionary<string, List<Person>>();
        public void addcontact()
        {
            Person person = new Person();
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhoneNo = Console.ReadLine();
            Console.Write("Enter Address : ");

            person.Address = Console.ReadLine();
            Console.Write("Enter city : ");
            person.City = Console.ReadLine();
            Console.Write("Enter pinCode : ");
            person.ZipCode = Console.ReadLine();
            Console.Write("Enter EmailId : ");
            person.EmailId = Console.ReadLine();
            person1.Add(person);
            Console.ReadLine();
        }
        //UC3-Edit person Details
        public void EditContact()
        {
            Console.WriteLine("Enter the 1st Name to edit the details");
            string firstName = Console.ReadLine();
            foreach (var contact in person1)
            {
                if (contact.FirstName.Equals(firstName))
                {
                    Console.WriteLine("Enter the 1st name to Edit");
                    contact.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter the last name to Edit");
                    contact.LastName = Console.ReadLine();
                }
            }
        }
        //UC4-Delete contact Details
        public void RemoveDetails()
        {
            Console.WriteLine("Enter the first Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last Name");
            string LastName = Console.ReadLine();
            Person person = new Person();
            foreach (var contact in person1.ToList())
            {
                if (contact.FirstName.Equals(FirstName) && contact.LastName.Equals(LastName))
                {
                    Console.WriteLine("RemoveContact" + contact);
                    person1.Remove(contact);
                }
            }
            //Console.WriteLine("Contacts are successfully Deleted" + person1.Remove(person));                
        }
        public void displayDetails()
        {
            foreach (var contact in person1)
            {
                Console.WriteLine(contact.FirstName);
                Console.WriteLine(contact.LastName);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.PhoneNo);
                Console.WriteLine(contact.ZipCode);
                Console.WriteLine(contact.EmailId);
            }
        }
        // UC5
        public void CreateDict()
        {
            Console.WriteLine("Enter a name here");
            string name = Console.ReadLine();
            person2.Add(name, person1);
            person1 = new List<Person>();
        }
       
    }
}