using System;
using System.Collections.Generic;
using System.Text;

namespace _04_С__Classes_Home_Work
{
    public class WebSite
    {
        private string name = "Unknown";
        private string adress = "None";
        private string description = "No description";
        private string ip = "0.0.0.0";

        public WebSite() { }

        public WebSite(string name, string adress, string description, string ip)
        {
            Name = name;
            Adress = adress;
            Description = description;
            IP = ip;
        }

        public void Input()
        {
            Console.Write("Enter site name: ");
            Name = Console.ReadLine();

            Console.Write("Enter site Adress : ");
            Adress = Console.ReadLine();
           
            Console.Write("Enter site IP address: ");
            IP = Console.ReadLine();

            Console.Write("Enter site description: ");
            Description = Console.ReadLine();

        }

        public void Print()
        {
            Console.WriteLine($"Name        :: {name}");
            Console.WriteLine($"Adress        :: {adress}");
            Console.WriteLine($"IP address  :: {ip}");
            Console.WriteLine($"Description :: {description}");
        }

        public override string ToString()
        {
            return $"Name : {name,-10} Adress : {adress,-10} IP : {ip,-10} Description : {description,-10}";
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    adress = value;
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

        public string IP
        {
            get
            {
                return ip;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    ip = value;
            }
        }
    }
}
