using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                if (B > C)
                {
                    Console.WriteLine("Сумма наибольших чисел: {0}", A + B);
                }
                else
                {
                    Console.WriteLine("Сумма наибольших чисел: {0}", A + C);
                }
            }
            else
            {
                if (C > A)
                {
                    Console.WriteLine("Сумма наибольших чисел: {0}", C + B);
                }
                else
                {
                    Console.WriteLine("Сумма наибольших чисел: {0}", B + A);
                }
            }
        }
    }
}
