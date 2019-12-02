using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и B");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            if (A == B)
            {
                A = 0;
                B = 0;
            }
            else
            {
                if (A < B)
                {
                    A = B;
                }
                if (B < A)
                {
                    B = A;
                }
            }
            Console.WriteLine("Новые зачения A и B: {0}, {1}", A, B);
        }
    }
}
