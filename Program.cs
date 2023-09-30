﻿using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
// console debug "dotnet run"
{

    internal class Program
    {

        public static void swap(ref NhanVien swNv1,ref NhanVien swNv2)
        {

            NhanVien tempNV = swNv1;

            swNv1 = swNv2;

            swNv2 = tempNV;

        }
           

        static void Main(string[] args)
        {





       while (true)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();


            Console.WriteLine("0 : Them nhan vien");

            Console.WriteLine("1 : Xem danh sach sinh vien");

            Console.WriteLine("2 : Tao danh sach ngau nhien");

            Console.WriteLine("3 : Tao danh sach tu Excel");

            Console.WriteLine("4 : Tao danh sach tu Word");
            Console.WriteLine("Nhập một số từ 0 đến 5 (hoặc nhập -1 để thoát):");

            Stopwatch stopwatch = new Stopwatch();
            // Bắt đầu đo thời gian
            stopwatch.Start();


            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit" || userInput.ToLower() == "-1")
            {
                Console.WriteLine("Chương trình đã thoát.");
                break; // Thoát khỏi vòng lặp
            }

            if (int.TryParse(userInput, out int value) && value >= 0 && value <= 5)
            {
                switch (value)
                {
                    case 0:

                        string HoTen = Console.ReadLine();
                        string MaNhanVien = Console.ReadLine();
                        double HeSoLuong = int.Parse(Console.ReadLine());
                        
                        quanLyNhanVien.ThemNhanVien(new NhanVien(HoTen,MaNhanVien,HeSoLuong));


                        break;
                    case 1:
                        quanLyNhanVien.DocDanhSachNhanVien();

                        break;
                    case 2:
                        Console.WriteLine("Nhap so luong vao");
                        int soluong = int.Parse(Console.ReadLine());
                        quanLyNhanVien.TaoDanhSachNhanVienNgauNhien(soluong);

                        break;
                    case 3:
                        HeThong excel = new Excel();
                        quanLyNhanVien.setLstNhanVien(excel.layDanhSachTuFile("/home/vokhanh/development/csharp/homeworks/danhsachnhanvien.xlsx"));

                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Giá trị là 5");
                        break;
                    default:
                        Console.WriteLine("Giá trị không nằm trong khoảng từ 0 đến 5");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập lại.");
            }

        

            // Lấy thời gian đã đo được
            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine($"Thời gian đã trôi qua: {elapsedTime.TotalMilliseconds} milliseconds");




     

        }





   

    }
    
}
}