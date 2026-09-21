using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION04
{
    internal class BTSlide1
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            //1. Write a C# Sharp program that takes two numbers as input and performs an operation(+,-,*, x,/) on them and displays the result of that operation.
            Console.Write("Nhập số a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");

            if (b != 0)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            else
            {
                Console.WriteLine("Phép chia: Không thể chia cho 0!");
            }
            // 2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
            Console.WriteLine("y\tx = y^2 + 2y + 1");
            Console.WriteLine("---------------------");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"{y}\t{x}");
            }
            // 3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km / h) and miles per hour(miles/h).
            Console.Write("Nhập khoảng cách (mét): ");
            float distance = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhập số giờ: ");
            float hours = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhập số phút: ");
            float minutes = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhập số giây: ");
            float seconds = Convert.ToSingle(Console.ReadLine());

            // Quy đổi tổng thời gian ra giờ
            float totalHours = hours + (minutes / 60f) + (seconds / 3600f);

            float kph = (distance / 1000f) / totalHours; // km/h
            float mph = kph / 1.609f;                   // miles/h

            Console.WriteLine($"Vận tốc (km/h): {kph:F2}");
            Console.WriteLine($"Vận tốc (miles/h): {mph:F2}");
            // 4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.V = 4 / 3 * π * r
            Console.Write("Nhập bán kính hình cầu (r): ");
            double r = Convert.ToDouble(Console.ReadLine());

            // Phải dùng 4.0 / 3.0 để C# chia số thực (không dùng 4 / 3)
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

            Console.WriteLine($"Diện tích bề mặt: {surface:F2}");
            Console.WriteLine($"Thể tích: {volume:F2}");
            // 5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.Write("Nhập một ký tự: ");
            char ch = Convert.ToChar(Console.ReadLine());

            // Chuyển về chữ thường để dễ kiểm tra
            char lowerCh = char.ToLower(ch);

            if ("aeiou".Contains(lowerCh))
            {
                Console.WriteLine($"{ch} là một Nguyên âm (Vowel).");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"{ch} là một Chữ số (Digit).");
            }
            else
            {
                Console.WriteLine($"{ch} là Ký hiệu / Ký tự khác.");
            }
        }
    }
}
