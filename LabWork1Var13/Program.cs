using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вариант 13. Реализовать функцию возведения в квадрат частного двух целых чисел.
namespace LabWork1Var13
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a);
            string b = Console.ReadLine();
            int y = Convert.ToInt32(b);
            var res = SquareQuotient(x, y); 
            Console.WriteLine("Ответ: {0}", res); 
            Console.ReadKey();
        }
        
        static int SquareQuotient(int x, int y)
        {
            int quotient = x / y;
            int result = quotient * quotient;

            return result;
        }
    }
}
