using System;
using System.Collections.Generic;
using System.Globalization;
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
        private decimal price = -1;

        // Constructors
        public Fruit(string name, bool isSweet, decimal price)
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
        public decimal Price
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
                Price = (decimal)r.NextDouble() * 10
            };
        }

        public override string ToString()
        {
            string formattedOutput = "";
            formattedOutput += name.PadRight(10);
            if(isSweet)
            {
                formattedOutput += "Sweet".PadRight(10);
            }
            else
            {
                formattedOutput += "Not Sweet".PadRight(10);
            }
            var priceRound = Math.Round(price , 2);
            formattedOutput += $"{priceRound.ToString().PadRight(4)} PLN";
            return formattedOutput;
        }

        public async Task<string> ToStringAsync()
        {
            string formattedOutput = "";
            formattedOutput += name.PadRight(10);
            if (isSweet)
            {
                formattedOutput += "Sweet".PadRight(10);
            }
            else
            {
                formattedOutput += "Not Sweet".PadRight(10);
            }
            UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();

            var priceRound = Math.Round(price, 2);
            var priceRoundUsd = Math.Round(price / UsdCourse.Current, 2);

            formattedOutput += $"[{MyFormatter.FormatPlnPrice(priceRound)} | {MyFormatter.FormatUsdPrice(priceRoundUsd)} ]";

            return formattedOutput;
        }
       

    }

}
