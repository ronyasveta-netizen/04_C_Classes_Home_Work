using System;
using System.Collections.Generic;
using System.Text;

namespace _04_С__Classes_Home_Work
{
    public class Store
    {
        private string name = "Unknown";
        private string profile = "No profile";
        private string address = "No address";
        private string phone = "38_(050)_0000_000";
        private string email = "none@example.com";

        public Store() { }

        public Store(string name, string profile, string address,  string phone, string email)
        {
            Name = name;
            Profile = profile;
            Address = address;            
            Phone = phone;
            Email = email;
        }

        public void Input()
        {
            Console.Write("Enter store name: ");
            Name = Console.ReadLine();

            Console.Write("Enter store profile description: ");
            Profile = Console.ReadLine();

            Console.Write("Enter store address: ");
            Address = Console.ReadLine();

            Console.Write("Enter contact phone: ");
            Phone = Console.ReadLine();

            Console.Write("Enter contact email: ");
            Email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Name     :: {name}");
            Console.WriteLine($"Profile  :: {profile}");
            Console.WriteLine($"Address  :: {address}");            
            Console.WriteLine($"Phone    :: {phone}");
            Console.WriteLine($"Email    :: {email}");
        }

        public override string ToString()
        {
            return $"Name : {name,-10} Profile : {profile,-10} Address : {address,-10} Phone : {phone,-10} Email : {email,-10}";
        }

        public string Name
        {
            get
            {  
                return name ;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public string Address
        {
            get
            {
                return address ;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    address = value;
            }
        }

        public string Profile
        {
            get
            {
                return profile ;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    profile = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone ;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email ;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    email = value;
            }
        }
    }
}
