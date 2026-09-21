using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION03
{
    internal class EX
    {
        public static void Main1(string[] args)
        {
            Console.Write("Nhap nhiet do Celsius: ");
            int celsius = int.Parse(Console.ReadLine());
            int kelvin = celsius + 273;
            int fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Nhiet do tu Celsius sang Kelvin: {kelvin}");
            Console.WriteLine($"Nhiet do tu Celsius sang Fahrenheit: {fahrenheit}");

            Console.WriteLine("Nhap radius: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double surfaceArea = 4 * pi * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);
            Console.WriteLine($"Surface: {surfaceArea:F2}");
            Console.WriteLine($"Volume: {volume:F1}");

            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");

        }
    }
}
