using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION04
{
    internal class B4_2
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Bai8();
        }
        static void Bai1()
        {
            //1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            double a, b, c;
            Console.Write("Nhập cạnh thứ nhất: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh thứ hai: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh thứ ba: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác là tam giác đều.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giác là tam giác cân.");
            }
            else
            {
                Console.WriteLine("Tam giác là tam giác thường.");
            }
        }
        static void Bai2()
        {
            //2.Write a program to read 10 numbers and find their average and sum.
            int total = 10;
            double sum = 0;
            Console.WriteLine($"Nhập vào {total} số:");
            for (int i = 1; i <= total; i++)
            {
                Console.Write($"Số thứ {i}: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            double average = sum / total;
            Console.WriteLine($"Tổng: {sum}");
            Console.WriteLine($"Trung bình: {average}");
        }
        static void Bai3()
        {
            //3. Write a program to display the multiplication table of a given integer
            int total = 10;
            Console.Write("Nhập một số nguyên: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương của {number}:");
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        static void Bai4va5()
        {
            //1
            //12
            //123
            //1234
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            //1
            //23
            //456
            //78910
            int rows2 = 4;
            int count = 1;
            for (int i = 1; i <= rows2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
            //   1
            //  2 3
            // 4 5 6
            //7 8 9 10
            int rows3 = 4;
            int count3 = 1;
            for (int i = 1; i <= rows3; i++)
            {
                int space = rows3 - i;
                for (int s = 1; s <= space; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count3 + " ");
                    count3++;
                }
                Console.WriteLine();
            }
        }
        static void Bai6()
        {
            //In chuỗi Harmonic và tính tổng
            Console.Write("Nhập số phần tử n:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            Console.Write("Chuỗi Harmonic:");
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                if (i == 1)
                    Console.Write("1");
                else
                    Console.Write($"+1/{i}");
            }
            Console.WriteLine($"\n Tổng của chuỗi ={sum}");
        }
        static void Bai7()
        {
            Console.Write("Nhập số bắt đầu:");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Nhập số kết thúc:");
            int end = int.Parse(Console.ReadLine());
            Console.Write($"\nCác số hoàn hảo trong khoảng [{start},{end}] là:");
            for (int num = start; num <= end; num++)
            {
                if (num <= 1) continue;
                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == num)
                { Console.Write(num + " "); }
            }
        }
        static void Bai8()
        {
            // Write a program to determine whether a given number is prime or not.
            Console.Write("Nhập số cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n <= 1)
            {
                isPrime = false;
            }
            else {
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            }    
        }
    }
}
