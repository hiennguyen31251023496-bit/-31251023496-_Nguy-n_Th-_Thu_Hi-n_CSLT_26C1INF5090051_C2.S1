using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION04
{
    internal class PTbac2
    {
        //Viết chương trình giải phương trình bậc 2 ax^2 + bx + c = 0 (a ≠ 0). Nhập a, b, c từ bàn phím. Xuất ra nghiệm của phương trình.
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập hệ số a (a ≠ 0):");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Hệ số a phải khác 0.");
                return;
            }
            Console.WriteLine("Nhập hệ số b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
    }
}
