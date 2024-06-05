using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeSeObesamm
{
    public class RandomPicker
    {
        private readonly string[] words =
       {
            "Argentina",
            "Australia",
            "Greenland",
            "Guatamala",
            "Indonesia",
            "Lithuania",
            "Macedonia",
            "Mauritius",
            "Nicaragua",
            "Venezuela",

        };
        private Random random;
        public RandomPicker()
        {
            random = new Random();
        }
        public string pick()
        {
            return words[random.Next(words.Length)];
        }
    }
}
