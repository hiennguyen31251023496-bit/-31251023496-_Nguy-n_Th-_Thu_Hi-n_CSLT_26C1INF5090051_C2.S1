using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION09
{
    internal class BTstrings
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.WriteLine("1. Nhập và in chuỗi ");
            Console.Write("Nhập chuỗi: ");
            string input1 = Console.ReadLine() ?? "";
            Console.WriteLine($"Chuỗi đã nhập: {input1}\n");

            Console.WriteLine("2. Độ dài chuỗi (không dùng hàm thư viện)");
            int length2 = 0;
            foreach (char c in input1) length2++;
            Console.WriteLine($"Độ dài chuỗi: {length2}\n");

            Console.WriteLine(" 3. Tách từng ký tự trong chuỗi ");
            Console.Write("Các ký tự: ");
            foreach (char c in input1) Console.Write($"{c} ");
            Console.WriteLine("\n");

            Console.WriteLine(" 4. In các ký tự theo thứ tự đảo ngược ");
            Console.Write("Chuỗi đảo ngược: ");
            for (int i = length2 - 1; i >= 0; i--) Console.Write(input1[i]);
            Console.WriteLine("\n");

            Console.WriteLine(" 5. Đếm tổng số từ trong chuỗi ");
            int wordCount = 0;
            bool inWord = false;
            foreach (char c in input1)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (!inWord) { wordCount++; inWord = true; }
                }
                else { inWord = false; }
            }
            Console.WriteLine($"Số từ: {wordCount}\n");

            Console.WriteLine(" 6. So sánh hai chuỗi (không dùng hàm thư viện)");
            Console.Write("Nhập chuỗi thứ nhất: ");
            string strA = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi thứ hai: ");
            string strB = Console.ReadLine() ?? "";
            bool isEqual = true;
            if (strA.Length != strB.Length)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < strA.Length; i++)
                {
                    if (strA[i] != strB[i]) { isEqual = false; break; }
                }
            }
            Console.WriteLine(isEqual ? "Hai chuỗi bằng nhau." : "Hai chuỗi không bằng nhau.\n");

            Console.WriteLine("7. Đếm số chữ cái, chữ số và ký tự đặc biệt");
            int alphabets = 0, digits = 0, specials = 0;
            foreach (char c in input1)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else if (!char.IsWhiteSpace(c)) specials++;
            }
            Console.WriteLine($"Chữ cái: {alphabets}, Chữ số: {digits}, Ký tự đặc biệt: {specials}\n");

            Console.WriteLine("8. Đếm số nguyên âm và phụ âm ");
            int vowels = 0, consonants = 0;
            string lowerInput = input1.ToLower();
            foreach (char c in lowerInput)
            {
                if (c >= 'a' && c <= 'z')
                {
                    if ("aeiou".Contains(c)) vowels++;
                    else consonants++;
                }
            }
            Console.WriteLine($"Nguyên âm: {vowels}, Phụ âm: {consonants}\n");

            Console.WriteLine("9. Kiểm tra chuỗi con có tồn tại không");
            Console.Write("Nhập chuỗi con cần kiểm tra: ");
            string sub9 = Console.ReadLine() ?? "";
            Console.WriteLine(input1.Contains(sub9) ? "Có chứa chuỗi con." : "Không chứa chuỗi con.\n");

            Console.WriteLine("=== 10. Tìm vị trí (index) của chuỗi con ===");
            int pos = input1.IndexOf(sub9);
            if (pos != -1) Console.WriteLine($"Vị trí xuất hiện đầu tiên: {pos}\n");
            else Console.WriteLine("Không tìm thấy chuỗi con.\n");

            Console.WriteLine("11. Kiểm tra ký tự thuộc bảng chữ cái và kiểm tra hoa/thường");
            Console.Write("Nhập 1 ký tự: ");
            char ch11 = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(ch11))
            {
                if (char.IsUpper(ch11)) Console.WriteLine($"'{ch11}' là chữ cái in HOA.\n");
                else Console.WriteLine($"'{ch11}' là chữ cái in thường.\n");
            }
            else
            {
                Console.WriteLine($"'{ch11}' không phải là chữ cái.\n");
            }

            Console.WriteLine("12. Đếm số lần xuất hiện của chuỗi con");
            Console.Write("Nhập chuỗi con cần đếm: ");
            string sub12 = Console.ReadLine() ?? "";
            int count12 = 0, index12 = 0;
            if (!string.IsNullOrEmpty(sub12))
            {
                while ((index12 = input1.IndexOf(sub12, index12)) != -1)
                {
                    count12++;
                    index12 += sub12.Length;
                }
            }
            Console.WriteLine($"Chuỗi '{sub12}' xuất hiện {count12} lần.\n");

            Console.WriteLine("13. Chèn chuỗi con vào trước vị trí xuất hiện đầu tiên của một chuỗi");
            Console.Write("Nhập chuỗi đích cần tìm: ");
            string target = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi con cần chèn: ");
            string toInsert = Console.ReadLine() ?? "";
            int targetPos = input1.IndexOf(target);
            if (targetPos != -1)
            {
                string result13 = input1.Insert(targetPos, toInsert);
                Console.WriteLine($"Kết quả sau khi chèn: {result13}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy chuỗi đích để chèn.");
            }
        } 

        }
}
