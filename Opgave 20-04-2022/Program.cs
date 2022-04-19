using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Bird b1 = new Bird(rand.Next(1,101),"Mark");
            Bird b2 = new Bird(rand.Next(1, 101), "Loke");
            Bird b3 = new Bird(rand.Next(1, 101), "Lars");
            Car c1 = new Car(rand.Next(1, 101), "Porsche Taycan");
            Car c2 = new Car(rand.Next(1, 101), "Mercury Marauder");
            Car c3 = new Car(rand.Next(1, 101), "Corvette Stingray");
            Bananan ba1 = new Bananan(rand.Next(1, 101), "Sød");
            Bananan ba2 = new Bananan(rand.Next(1, 101), "Sur");
            Bananan ba3 = new Bananan(rand.Next(1, 101), "Stærk");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("******************************************************");
                    Console.WriteLine("");
                    Console.WriteLine($"Navn: {b1.Name} Alder: {b1.Age}");
                    Console.WriteLine($"Navn: {c1.Name} Alder: {c1.Age}");
                    Console.WriteLine($"Navn: {ba1.Name} Alder: {ba1.Age}");
                    Console.WriteLine("");
                    Console.WriteLine("******************************************************");
                    Console.WriteLine("");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"Navn: {b2.Name} Alder: {b2.Age}");
                    Console.WriteLine($"Navn: {c2.Name} Alder: {c2.Age}");
                    Console.WriteLine($"Navn: {ba2.Name} Alder: {ba2.Age}");
                    Console.WriteLine("");
                    Console.WriteLine("******************************************************");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"Navn: {b3.Name} Alder: {b3.Age}");
                    Console.WriteLine($"Navn: {c3.Name} Alder: {c3.Age}");
                    Console.WriteLine($"Navn: {ba3.Name} Alder: {ba3.Age}");
                    Console.WriteLine("");
                    Console.WriteLine("******************************************************");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine($"Alder summen: {b1.Age + b2.Age + b3.Age + c1.Age + c2.Age + c3.Age + ba1.Age + ba2.Age + ba3.Age}");
            Console.ReadKey();

        }
    }
}
