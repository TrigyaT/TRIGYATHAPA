using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before Swapping={num1},{num2}");
            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine($"After Swapping={num1},{num2}");
        }
    }
}
