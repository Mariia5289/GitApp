using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = 5 *Math.Sin(x) - 7 * Math.Cos(x);
            Console.WriteLine(x + " " +F);
            Console.ReadKey();//конец кода

            return;
        }
    }
}
