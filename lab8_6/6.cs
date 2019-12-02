using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.Write("Четное ");
            }
            else
            {
                Console.Write("Нечетное ");
            }
            if (a < 10)
            {
                Console.Write("однозначное ");
            }
            else
            {
                if (a < 100 && a > 9)
                {
                    Console.Write("двузначное ");
                }
                else
                {
                    Console.Write("трехзначное ");
                }
            }
            Console.Write("число");

            Console.ReadKey();       
        }
    }
}
