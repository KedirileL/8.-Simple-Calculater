using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Simple_Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = (int)Convert.ToDouble(Console.ReadLine());
            int num4 = num1 + num2 + num3; 

            Console.WriteLine(num1 + " + " + num2+ " + " + num3 + " = " + num4);

            Console.ReadLine();
        }
    }
}
