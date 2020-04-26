using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            // int.TryParse(Console.ReadLine(), out int b);
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine($"Liczba {a} jest podzielna przez liczbę {b}");
            }
            else {
                Console.WriteLine($"Liczba {a} NIE jest podzielna przez liczbę {b}");
            }


        }
    }
}
