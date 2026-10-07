using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION09
{
    internal class BTfiles
    {
        static void Main(string[] args)
        {

            // Gọi thử nghiệm các hàm
            Cau1("test.txt");
            Cau3("test.txt", "Xin chào! Đây là file thử nghiệm.");
            Cau4("test.txt");
            Cau5("array_test.txt", new string[] { "Dòng 1", "Dòng 2", "Dòng 3" });
            Cau6("test.txt", "\nDòng này được nối thêm vào.");
            Cau7("test.txt", "copy_test.txt");
            Cau8("copy_test.txt", "renamed_test.txt");
            Cau9("test.txt");
            Cau10("test.txt");
            Cau11("array_test.txt", 2);
            Cau12("array_test.txt", 2);
            Cau13("array_test.txt");

            Console.WriteLine("\n--- Cấu trúc thư mục hiện tại ---");
            Cau14("./");

            Console.WriteLine("\n--- Thống kê ký tự file ---");
            Cau15("test.txt");

            // Cau2("test.txt"); // Dùng để xóa file khi cần
        }

        // 1. Create a blank file on the disk
        public static void Cau1(string path)
        {
            File.Create(path).Close();
            Console.WriteLine($"[Cau1] Đã tạo file rỗng: {path}");
        }

        // 2. Remove a file from the disk
        public static void Cau2(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"[Cau2] Đã xóa file: {path}");
            }
            else
            {
                Console.WriteLine($"[Cau2] File không tồn tại: {path}");
            }
        }

        // 3. Create a file and add some text
        public static void Cau3(string path, string text)
        {
            File.WriteAllText(path, text);
            Console.WriteLine($"[Cau3] Đã tạo và ghi nội dung vào file: {path}");
        }

        // 4. Create a text file and read it
        public static void Cau4(string path)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine($"[Cau4] Nội dung file {path}:\n{content}");
            }
        }

        // 5. Create a file and write an array of strings to the file
        public static void Cau5(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
            Console.WriteLine($"[Cau5] Đã ghi {lines.Length} dòng vào file: {path}");
        }

        // 6. Append some text to an existing file
        public static void Cau6(string path, string text)
        {
            File.AppendAllText(path, text);
            Console.WriteLine($"[Cau6] Đã nối thêm văn bản vào file: {path}");
        }

        // 7. Create and copy the file to another name and display the content
        public static void Cau7(string sourcePath, string destPath)
        {
            File.Copy(sourcePath, destPath, overwrite: true);
            Console.WriteLine($"[Cau7] Nội dung file sau khi copy sang {destPath}:");
            Console.WriteLine(File.ReadAllText(destPath));
        }

        // 8. Create a file and move it into the same directory with another name
        public static void Cau8(string oldPath, string newPath)
        {
            if (File.Exists(newPath)) File.Delete(newPath);
            File.Move(oldPath, newPath);
            Console.WriteLine($"[Cau8] Đã đổi tên/di chuyển file {oldPath} thành {newPath}");
        }

        // 9. Read the first line of a file
        public static void Cau9(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine($"[Cau9] Dòng đầu tiên: {firstLine}");
                }
            }
        }

        // 10. Create and read the last line of a file
        public static void Cau10(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0)
                {
                    Console.WriteLine($"[Cau10] Dòng cuối cùng: {lines[lines.Length - 1]}");
                }
            }
        }

        // 11. Create and read the last n lines of a file
        public static void Cau11(string path, int n)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                var lastN = lines.TakeLast(n);
                Console.WriteLine($"[Cau11] {n} dòng cuối cùng của file:");
                foreach (var line in lastN)
                {
                    Console.WriteLine("  " + line);
                }
            }
        }

        // 12. Read a specific line from a file (1-indexed)
        public static void Cau12(string path, int lineNumber)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lineNumber > 0 && lineNumber <= lines.Length)
                {
                    Console.WriteLine($"[Cau12] Dòng {lineNumber}: {lines[lineNumber - 1]}");
                }
                else
                {
                    Console.WriteLine($"[Cau12] Dòng {lineNumber} vượt quá số dòng hiện có.");
                }
            }
        }

        // 13. Count the number of lines in a file
        public static void Cau13(string path)
        {
            if (File.Exists(path))
            {
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine($"[Cau13] Tổng số dòng trong file {path}: {count}");
            }
        }

        // 14. Print the structure of specific folder (include files)
        public static void Cau14(string folderPath, string indent = "")
        {
            if (Directory.Exists(folderPath))
            {
                DirectoryInfo dir = new DirectoryInfo(folderPath);
                Console.WriteLine(indent + "[Folder] " + dir.Name);
                indent += "   ";

                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine(indent + "- " + file.Name);
                }

                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    Cau14(subDir.FullName, indent);
                }
            }
        }

        // 15. Calculate character and number statistics using 2D Rectangular Array & Jagged Array
        public static void Cau15(string path)
        {
            if (!File.Exists(path)) return;

            // 1. Mảng chữ nhật [ASCII code, tần suất]
            int[,] charCount = new int[256, 2];
            for (int i = 0; i < 256; i++)
            {
                charCount[i, 0] = i;
                charCount[i, 1] = 0;
            }

            List<Tuple<int, int>>[] tempLocations = new List<Tuple<int, int>>[256];
            for (int i = 0; i < 256; i++) tempLocations[i] = new List<Tuple<int, int>>();

            string[] lines = File.ReadAllLines(path);
            for (int r = 0; r < lines.Length; r++)
            {
                for (int c = 0; c < lines[r].Length; c++)
                {
                    int ascii = (int)lines[r][c];
                    if (ascii < 256)
                    {
                        charCount[ascii, 1]++;
                        tempLocations[ascii].Add(new Tuple<int, int>(r + 1, c + 1));
                    }
                }
            }

            // 2. Jagged Array lưu vị trí (dòng, cột)
            int[][][] positions = new int[256][][];
            for (int i = 0; i < 256; i++)
            {
                positions[i] = new int[tempLocations[i].Count][];
                for (int j = 0; j < tempLocations[i].Count; j++)
                {
                    positions[i][j] = new int[] { tempLocations[i][j].Item1, tempLocations[i][j].Item2 };
                }
            }

            Console.WriteLine($"[Cau15] BẢNG THỐNG KÊ KÝ TỰ & SỐ TRONG FILE '{path}':");
            for (int i = 0; i < 256; i++)
            {
                int count = charCount[i, 1];
                char ch = (char)i;

                if (count > 0 && char.IsLetterOrDigit(ch))
                {
                    Console.WriteLine($"Ký tự '{ch}' xuất hiện {count} lần:");
                    Console.Write("  Vị trí (Dòng, Cột): ");
                    for (int k = 0; k < positions[i].Length; k++)
                    {
                        Console.Write($"({positions[i][k][0]},{positions[i][k][1]}) ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
