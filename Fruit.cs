using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    internal class Fruit
    {
        // Private fields
        private string name="null";
        private bool isSweet = false;
        private double price = -1;

        // Constructors
        public Fruit(string name, bool isSweet, double price)
        {
            Name = name;
            IsSweet = isSweet;
            Price = price;
        }
        public Fruit() { }  

        // Public fields  (getters and setters)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsSweet
        {
            get { return isSweet; }
            set { isSweet = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public static Fruit Create()
        {
            Random r = new Random();
            string[] names = new string[] { "Apple", "Banana", "Cherry", "Durian", "Edelberry", "Grape", "Jackfruit" };
            return new Fruit{
                Name = names[r.Next(names.Length)],
                IsSweet = r.NextDouble() > 0.5,
                Price = r.NextDouble() * 10
            };
        }

        public void show()
        {
            Console.Write($"{name.PadRight(8)}\t");
            if(isSweet)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write("Sweet".PadRight(8));
            Console.ForegroundColor = ConsoleColor.White;

            var priceRound = Math.Round(price, 2);
            Console.Write($"{priceRound.ToString().PadRight(4)} PLN\n");
        }
    }

}
