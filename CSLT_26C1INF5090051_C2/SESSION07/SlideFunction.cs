using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION07
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Bai_6();
        }
        static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static int FindMaxAdvanced(int firstNumber, params int[] others)
        {
            int max = firstNumber;
            foreach (int num in others)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static long Findfactorial(int n)
        {
            long result = 1;
            System.Collections.Generic.List<int> danhsachso = new System.Collections.Generic.List<int>();
            for (int i = n; i >= 1; i--)
            {
                result *= i;
                danhsachso.Add(i);
            }
            //Nối các số trong danh sách thành một chuỗi để hiển thị
            string chuoiDanhSach = string.Join(" x ", danhsachso);
            Console.WriteLine($"\n{n}! = {chuoiDanhSach} = {result}");
            return result;
        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false; // Số nhỏ hơn hoặc bằng 1 không phải là số nguyên tố
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false; // Nếu n chia hết cho i thì không phải là số nguyên tố
            }
            return true; // Nếu không tìm thấy ước số nào, n là số nguyên tố
        }
        static void PrimelessthanN(int n)
        {
            Console.WriteLine($"Các số nguyên tố nhỏ hơn {n} là: ");
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); // In xuống dòng sau khi hiển thị tất cả các số nguyên tố
        }
        static void FirstNPrimeNumbers(int n)
        {
            Console.WriteLine($"Các số nguyên tố đầu tiên là: ");
            int count = 0;
            int number = 2; // Bắt đầu từ số nguyên tố đầu tiên
            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
            Console.WriteLine(); // In xuống dòng sau khi hiển thị tất cả các số nguyên tố
        }
        static bool IsPerfectNumber(int n)
        {
            if (n <= 1) return false; // Số nhỏ hơn hoặc bằng 1 không phải là số hoàn hảo
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"{n} là số hoàn hảo.");
                return true;
            }
            else
            {
                Console.WriteLine($"{n} không phải là số hoàn hảo.");
                return false;
            }
        }
        static void PrintPerfectNumbersUpToN(int n)
        {
            Console.WriteLine($"Các số hoàn hảo nhỏ hơn hoặc bằng {n} là: ");
            for (int i = 1; i <= n; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); // In xuống dòng sau khi hiển thị tất cả các số hoàn hảo
        }
        static bool IsPangram(string str)
        {
            str= str.ToLower(); // Chuyển chuỗi về chữ thường để so sánh
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!str.Contains(c))
                {
                    return false; // Nếu thiếu bất kỳ chữ cái nào, không phải là pangram
                }
            }
            return true; // Nếu có đủ tất cả các chữ cái, là pangram
        }
        static void Bai_1()
        {
            Console.WriteLine("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = FindMax(a, b, c);
            Console.WriteLine($"Giá trị lớn nhất là: {max}");
            // Ví dụ nâng cao
            int maxAdvanced = FindMaxAdvanced(a, b, c, 10, 20);
            Console.WriteLine($"Giá trị lớn nhất (nâng cao) là: {maxAdvanced}");
        }
        static void Bai_2()
        {
            int n;
            // Vòng lặp giữ chân người dùng cho đến khi nhập đúng số nguyên không âm
            while (true)
            {
                Console.Write("Nhập một số nguyên không âm (n >= 0): ");
                string input = Console.ReadLine();

                // Kiểm tra xem có phải là số nguyên hợp lệ không VÀ có lớn hơn hoặc bằng 0 không
                if (int.TryParse(input, out n) && n >= 0)
                {
                    break; // Nhập đúng rồi thì thoát vòng lặp để đi tính toán
                }

                Console.WriteLine("Nhập sai rồi! Vui lòng chỉ nhập số nguyên >= 0 (ví dụ: 0, 1, 5, 10).\n");
            }

            Findfactorial(n); // Gọi hàm tính giai thừa

        }
        static void Bai_3()
        {
            Console.WriteLine("Nhập số nguyên dương n:  ");
            int number = int.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số nguyên tố.");
            }
        }
        static void Bai_4()
        {
            Console.WriteLine("Nhập số N: ");
            int n = int.Parse(Console.ReadLine());
            PrimelessthanN(n);
            FirstNPrimeNumbers(n);
        }
        static void Bai_5()
        {
            PrintPerfectNumbersUpToN(10000); // In các số hoàn hảo nhỏ hơn hoặc bằng 10000
        }
        static void Bai_6()
        {
            Console.WriteLine("Nhập một chuỗi: ");
            string input = Console.ReadLine();
            if (IsPangram(input))
            {
                Console.WriteLine("Chuỗi này là pangram.");
            }
            else
            {
                Console.WriteLine("Chuỗi này không phải là pangram.");
            }
        }

        }
}
