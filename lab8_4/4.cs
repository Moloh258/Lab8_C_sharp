using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X точки");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y точки");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Точка находится в I четверти");
                }
                else
                {
                    Console.WriteLine("Точка находится в IV четверти");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("Точка находится в II четверти");
                }
                else
                {
                    Console.WriteLine("Точка находится в III четверти");
                }
            }
        }
    }
}
