// Вариант 13. Реализовать функцию возведения в квадрат частного двух целых чисел.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Program method = new Program();
            Console.WriteLine("Введите число №1");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine("Введите число №2");
            string r = Console.ReadLine();
            int b = Convert.ToInt32(r);
            if (b == 0)
                Environment.Exit(0);
            Console.WriteLine("Квадрат частного двух целых чисел: " + method.LabWorkMethod(a, b));
            Console.ReadLine();
        }
        public int LabWorkMethod(int a, int b)
        {
            return ((a / b) * (a / b));
        }
    }
}