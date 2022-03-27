using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AddressBook
{
    class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zipcode;
        public int PhoneNumber;
        public string EmailId;
        public Contacts(string FirstName, string LastName, string Address, string City, string State, int Zipcode, int PhoneNumber, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;
        }
        public string ToString()
        {
            return " Details of " + FirstName + " " + LastName + " are: " + "Address: " + Address + " City: " + City + "\n"
                                  + "                                   " + " State:   " + State + " Zipcode: " + Zipcode + "\n"
                                  + "                                   " + "Phone Number:" + PhoneNumber + " EmailId: " + EmailId;
        }
    }
    class AddressBook
    {
        private ArrayList contactDetailsList;
        private Dictionary<string, Contacts> contactDetailsMap;
        public AddressBook()
        {
            contactDetailsList = new ArrayList();
            contactDetailsMap = new Dictionary<string, Contacts>();
        }
        public void AddDetails()
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            int ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Address");
            string Email = Console.ReadLine();
            Contacts contactDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            contactDetailsList.Add(contactDetails);
            contactDetailsMap.Add(FirstName, contactDetails);
        }
        public void EditDetails(string name)
        {
            if (contactDetailsMap.ContainsKey(name))
            {
                Console.WriteLine("Enter First name");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last name");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code");
                int ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number");
                int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Email Address");
                string Email = Console.ReadLine();
                Contacts contactDetails = new Contacts(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
                contactDetailsList.Add(contactDetails);
                contactDetailsMap[FirstName] = contactDetails;
            }
            else
            {
                Console.WriteLine("First Name not found");
            }
        }
        public void ComputeDetails()
        {
            foreach (Contacts contact in contactDetailsList)
            {
                Console.WriteLine(contact.ToString());
            }
        }
        public static void Main(string[] args)
        {
            int Option = 0;
            Console.WriteLine("Welcome To Address Book Program");
            AddressBook details = new AddressBook();
            do
            {
                Console.WriteLine("1 To Add a Contact Details");
                Console.WriteLine("2 To Edit a Contact Details");
                Console.WriteLine("0 To Exit");
                try
                {
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            details.AddDetails();
                            details.ComputeDetails();
                            break;
                        case 2:
                            Console.WriteLine("Enter First Name to Edit");
                            string Name = Console.ReadLine();
                            details.EditDetails(Name);
                            details.ComputeDetails();
                            break;
                        case 0:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Wrong opction");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose option");
                }
            }
            while (Option != 0);
        }
    }
}