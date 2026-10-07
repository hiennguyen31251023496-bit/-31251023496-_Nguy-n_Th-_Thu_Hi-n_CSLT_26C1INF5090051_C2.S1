using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION02
{
    internal class BTslides
    {
        static void Main()
        {
            // 1. Add / Sum Two Numbers
            Console.WriteLine("1. to Add / Sum Two Numbers");
            int num1 = 15, num2 = 25;
            int sum = num1 + num2;
            Console.WriteLine($"Tong cua {num1} va {num2} la: {sum}");

            // 2. Swap Values of Two Variables
            Console.WriteLine("2. to Swap Values of Two Variables");
            int a = 5, b = 10;
            Console.WriteLine($"Truoc khi hoan doi: a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Sau khi hoan doi: a = {a}, b = {b}");

            // 3. Multiply two Floating Point Numbers
            Console.WriteLine("3. to Multiply two Floating Point Numbers");
            float f1 = 2.5f, f2 = 4.2f;
            float product = f1 * f2;
            Console.WriteLine($"Tich cua {f1} va {f2} la: {product}");

            // 4. Convert feet to meter
            Console.WriteLine("4. to convert feet to meter");
            double feet = 10;
            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meters} meters");

            // 5. Convert Celsius to Fahrenheit and vice versa
            Console.WriteLine("5. to convert Celsius to Fahrenheit and vice versa");
            double celsius = 25;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            double backToCelsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F = {backToCelsius}°C");

            // 6. Find the Size of data types
            Console.WriteLine("6. to find the Size of data types");
            Console.WriteLine($"Kich thuoc cua int: {sizeof(int)} bytes");
            Console.WriteLine($"Kich thuoc cua float: {sizeof(float)} bytes");
            Console.WriteLine($"Kich thuoc cua double: {sizeof(double)} bytes");
            Console.WriteLine($"Kich thuoc cua char: {sizeof(char)} bytes");

            // 7. Print ASCII Value
            Console.WriteLine("7. to Print ASCII Value (tip: read character, print number of this char)");
            char ch = 'A';
            int asciiValue = (int)ch;
            Console.WriteLine($"Gia tri ASCII cua ky tu '{ch}' la: {asciiValue}");

            // 8. Calculate Area of Circle
            Console.WriteLine("8. to Calculate Area of Circle");
            double radius = 5.0;
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"Dien tich hinh tron ban kinh {radius} la: {circleArea:F2}");

            // 9. Calculate Area of Square
            Console.WriteLine("9. to Calculate Area of Square");
            double side = 4.0;
            double squareArea = side * side;
            Console.WriteLine($"Dien tich hinh vuong canh {side} la: {squareArea}");

            // 10. Convert days to years, weeks and days
            Console.WriteLine("10. to convert days to years, weeks and days");
            int totalDays = 800;
            int years = totalDays / 365;
            int remainingDaysAfterYears = totalDays % 365;
            int weeks = remainingDaysAfterYears / 7;
            int days = remainingDaysAfterYears % 7;
            Console.WriteLine($"{totalDays} ngay = {years} nam, {weeks} tuan, {days} ngay");
        }
    }
}
