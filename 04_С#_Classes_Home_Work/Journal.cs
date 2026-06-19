using System;
using System.Collections.Generic;
using System.Text;

namespace _04_С__Classes_Home_Work
{
    public class Journal
    {
        private string name = "Unknown";
        private int year = 1973;
        private string phone = "38_(050)_0000_000";
        private string email = "none@example.com";
        private string description = "No description";

        public Journal() { }

        public Journal(string name, int year, string phone, string email, string description)
        {
            Name = name;
            Year = year;
            Phone = phone;
            Email = email;
            Description = description;
        }

        public void Input()
        {
            Console.Write("Enter journal name: ");
            Name = Console.ReadLine();

            Console.Write("Enter foundation year: ");
            if (int.TryParse(Console.ReadLine(), out int year))
                Year = year;
            else
            {
                Console.WriteLine("!!! Error =>  year must be a number!");
                return;
            }
          
            Console.Write("Enter contact phone: ");
            Phone = Console.ReadLine();

            Console.Write("Enter contact email: ");
            Email = Console.ReadLine();

            Console.Write("Enter journal description: ");
            Description = Console.ReadLine();

        }

        public void Print()
        {
            Console.WriteLine($"Name        :: {name}");
            Console.WriteLine($"Year        :: {year}");            
            Console.WriteLine($"Phone       :: {phone}");
            Console.WriteLine($"Email       :: {email}");
            Console.WriteLine($"Description :: {description}");
        }

        public override string ToString()
        {
            return $"Name  : {name,-10}   Year : {year,-10} Phone : {phone,-10}   Email : {email,-10} Description : {description,-10}";
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

        public int Year
        {
            get
            {  
                return year ;
            }
            set
            {
                if (value >= 1665 && value <= DateTime.Now.Year)
                    year = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    description = value;
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
