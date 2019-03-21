using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Circle radius: ");
            double valueCircle = double.Parse(Console.ReadLine());
            double circleCircumference = 2 * Math.PI * valueCircle;
            double circleArea = Math.PI * (valueCircle * valueCircle);
            Console.WriteLine("Area: " + circleArea);
            Console.WriteLine("Circumference: " + circleCircumference);
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
