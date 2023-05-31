using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next(0,4);
            Console.WriteLine(randomInt);

            string[] cars = new string[4];
            cars[0] = "Audi";
            cars[1] = "BMW";
            cars[2] = "Ford";
            cars[3] = "VolksWagen";

            Console.WriteLine("[{0}]", string.Join(", ", cars));
            Console.WriteLine(cars[randomInt]);
        }
    }
}
