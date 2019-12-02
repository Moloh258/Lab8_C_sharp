using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки C");
            int C = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(A - B) > Math.Abs(A - C))
            {
                Console.WriteLine("Точка {0} ближе к точке А. Расстояние равно {1}", C, Math.Abs(A - C));
            }
            else
            {
                Console.WriteLine("Точка {0} ближе к точке А. Расстояние равно {1}", B, Math.Abs(A - B));
            }
        }
    }
}
