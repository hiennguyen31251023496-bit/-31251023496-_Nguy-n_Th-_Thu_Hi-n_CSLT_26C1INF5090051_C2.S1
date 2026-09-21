using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
namespace CSLT_26C1INF5090051_C2.SESSION04
{
    internal class B4_1
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Bai1();
            Bai2();
            Bai3();
        }
            static void Bai1()
            {
                // 1.Write a C# Sharp program to check whether a given number is even or odd.
                Console.Write("Nhập số nguyên:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} là số chẵn.");
                }
                else
                {
                    Console.WriteLine($"{number} là số lẻ.");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
            }
            }
            static void Bai2()
            {
                // 2.Write a C# Sharp program to find the largest of three numbers.
                Console.Write("Nhập số thứ nhất: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập số thứ hai: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập số thứ ba: ");
                double num3 = Convert.ToDouble(Console.ReadLine());

                double largest;

                if (num1 >= num2 && num1 >= num3)
                {
                    largest = num1;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    largest = num2;
                }
                else
                {
                    largest = num3;
                }

                Console.WriteLine($"Số lớn nhất là: {largest}");
            }
            static void Bai3()
            {
                // 3.Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
                Console.Write("Nhập hoành độ (x): ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập tung độ (y): ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Điểm nằm ở góc phần tư thứ nhất.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Điểm nằm ở góc phần tư thứ hai.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Điểm nằm ở góc phần tư thứ ba.");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Điểm nằm ở góc phần tư thứ tư.");
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine("Điểm nằm trên trục tung.");
                }
                else if (y == 0 && x != 0)
                {
                    Console.WriteLine("Điểm nằm trên trục hoành.");
                }
                else
                {
                    Console.WriteLine("Điểm nằm tại gốc tọa độ.");
                }
            }
    }
}