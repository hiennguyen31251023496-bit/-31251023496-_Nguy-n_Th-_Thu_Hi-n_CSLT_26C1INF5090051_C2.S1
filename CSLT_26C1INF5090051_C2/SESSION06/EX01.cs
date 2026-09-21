using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace CSLT_26C1INF5090051_C2.SESSION06
{
    internal class EX01
    {
        public static void Main1(string[] args)
        {
            guessing_game_engine();
        }

        ///    1. Máy tính nghĩ ngẫu nhiên 1 số [1-10]
        ///    2. Hỏi người dùng đoán số đó 
        ///    3. Nếu người dùng đoán đúng thì thông báo
        ///    nếu người dùng đoán nhỏ/lớn hơn thì thông báo nhỏ/lớn hơn
        ///    chơi cho đến khi người dùng chọn không chơi nữa
        ///    Thống kê số lần đoán đúng, số lần đoán sai
        static void guessing_game_engine()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            bool playAgain = true;
            int dem_thang = 0, tong_so_van = 0;
            int level = 1;
            int so_lan_doan = 0;
            do
            {
                tong_so_van++;
                //cho người dùng chọn mức độ
                Console.Write("Ban choi muc do nao <1-dễ ; 2-trung bình ; 3-khó> : ");
                level = int.Parse(Console.ReadLine());
                if (level == 1)
                    so_lan_doan = 9;
                else if (level == 2)
                    so_lan_doan = 6;
                else
                    so_lan_doan = 4;
                //Máy tính nghĩ ngẫu nhiên 1 số [1-10]
                Random rnd = new Random();
                int so_can_doan = rnd.Next(10) + 1;
                //Hỏi người dùng đoán số đó
                for (int i = 0; i < so_lan_doan; i++)
                {
                    Console.Write("Hãy đoán một số từ 1 đến 10: ");
                    int so_nguoi_dung = int.Parse(Console.ReadLine());
                    if (so_nguoi_dung == so_can_doan)
                    {
                        Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng sau {i + 1} lần chơi.");
                        dem_thang++;
                        break;
                    }
                    else if (so_nguoi_dung < so_can_doan)
                    {
                        Console.WriteLine("Số bạn đoán nhỏ hơn số cần đoán.");
                    }
                    else
                    {
                        Console.WriteLine("Số bạn đoán lớn hơn số cần đoán.");
                    }
                }
                Console.WriteLine($"Số máy nghĩa ra là: {so_can_doan}");
                //xong 1 lần chơi
                // hỏi người dùng có muốn chơi tiếp không
                Console.WriteLine("Bạn có muốn chơi tiếp không? (c/k): ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "k")
                {
                    playAgain = false;

                }
            } while (playAgain);
            Console.WriteLine($"Tổng số ván đã chơi: {tong_so_van}");
                Console.WriteLine($"Số ván đoán đúng (thắng): {dem_thang}");
                Console.WriteLine($"Số ván đoán sai (thua) : {tong_so_van - dem_thang}");
            
        
        }
        }
    } 
