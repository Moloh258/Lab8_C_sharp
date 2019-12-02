using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Нулевое число");
            }
            else
            {
                if (a > 0)
                {
                    Console.Write("Положительное ");
                }
                else
                {
                    Console.Write("Отрицательное ");
                }
                if (a % 2 == 0)
                {
                    Console.Write("четное ");
                }
                else
                {
                    Console.Write("нечетное ");
                }
                Console.Write("число");
            }
            Console.ReadKey();
        }
    }
}
