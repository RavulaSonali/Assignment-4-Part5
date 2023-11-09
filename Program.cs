using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int per;
            Console.WriteLine("Enter the percentage scored ");
            per = int.Parse(Console.ReadLine());
            if(per>=90)
                {
                Console.WriteLine("Your Grade is A");
            }
            else if (per >= 80 && per <=89)
            {
                Console.WriteLine("Your grade is B");
            }
            else if(per>=70 && per <=79)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (per>=60 && per<=69)
            {
                Console.WriteLine("Your Grade is D");
            }
            else
            {
                Console.WriteLine("Your Grade is E");
            }
            Console.ReadKey();
        }
    }
}
