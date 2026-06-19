using System;
using System.Collections.Generic;
using System.Text;

namespace _04_С__Classes_Home_Work
{
    public class Rezervuar
    {
        const double MIN = 0.0;
        const double MAX = 100.0;

        private double volume = 0.0;
        private string material = "NoName";
        private bool isFull = false;

        public Rezervuar() { }

        public Rezervuar(double volume, string material, bool isFull)
        {
            Volume = volume;
            Material = material;                 
            this.isFull = isFull;    
        }
        public Rezervuar(double volume): this(volume, "NoName", false) { }
        public Rezervuar(double volume, string material) : this(volume, material, false) { }


        public void Print()
        {
            Console.WriteLine($"Material :: {material}");
            Console.WriteLine($"Volume   :: {volume}");
            Console.WriteLine($"State    :: {(isFull ? "Full" : " It's not Full ")}");
            Console.WriteLine($"Can fill :: {CanFillMore}");
        }

        public override string ToString()
        {
            return $"Material: {material, -10}  Volume: {volume, - 10}  State: {(isFull ? " Full " : " It's not Full "),-10} Can fill : {CanFillMore, -10} ";
        }
        public double Volume
        {
            get
            { 
                return volume; 
            }
            set
            {
                if (value >= MIN && value <= MAX)
                    volume = value;
            }
        }

        public string Material
        {
            get
            {  
                return material;
            }
             
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    material = value;
            }
        }

        public void Fill(double amount)
        {
            if (isFull)
            {
                Console.WriteLine("Reservoir is  full!");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Fill amount must be positive.");
                return;
            }

            if (volume + amount >= MAX)
            {
                volume = MAX;
                isFull = true;
                Console.WriteLine("Reservoir filled to maximum.");
            }
            else
            {
                volume += amount;
                Console.WriteLine($"Filled by {amount}. Current volume: {volume}");
            }
        }

        public void Empty(double amount)
        {
            if (!isFull && volume == MIN)
            {
                Console.WriteLine("Reservoir is  empty!");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Empty amount must be positive.");
                return;
            }

            if (volume - amount <= MIN)
            {
                volume = MIN;
                isFull = false;
                Console.WriteLine("Reservoir emptied completely.");
            }
            else
            {
                volume -= amount;
                isFull = false;
                Console.WriteLine($"Emptied by {amount}. Current volume: {volume}");
            }
        }

        public double CanFillMore { get => MAX - volume; }






    }
}
