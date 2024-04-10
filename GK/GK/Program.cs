using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hộ dân: ");
            int n = int.Parse(Console.ReadLine());
            KhuPho khuPho = new KhuPho();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số thành viên của hộ {i + 1}: ");
                int soThanhVien = int.Parse(Console.ReadLine());
                Console.Write($"Nhập số con trai của hộ {i + 1}: ");
                int soConTrai = int.Parse(Console.ReadLine());
                Console.Write($"Nhập số nhà của hộ {i + 1}: ");
                int soNha = int.Parse(Console.ReadLine());

                HoGiaDinh hoGiaDinh = new HoGiaDinh
                {
                    SoThanhVien = soThanhVien,
                    SoConTrai = soConTrai,
                    SoNha = soNha,
                    DanhSachNguoi = new List<Nguoi>()
                };

                for (int j = 0; j < soThanhVien; j++)
                {
                    Console.Write($"Nhập họ tên của người thứ {j + 1}: ");
                    string hoTen = Console.ReadLine();
                    Console.Write($"Nhập tuổi của người thứ {j + 1}: ");
                    int tuoi = int.Parse(Console.ReadLine());
                    Console.Write($"Nhập nghề nghiệp của người thứ {j + 1}: ");
                    string ngheNghiep = Console.ReadLine();
                    Console.Write($"Nhập số CMND của người thứ {j + 1}: ");
                    string soCMND = Console.ReadLine();

                    Nguoi nguoi = new Nguoi
                    {
                        HoTen = hoTen,
                        Tuoi = tuoi,
                        NgheNghiep = ngheNghiep,
                        SoCMND = soCMND
                    };

                    hoGiaDinh.DanhSachNguoi.Add(nguoi);
                }

                khuPho.ThemHoGiaDinh(hoGiaDinh);
            }
            Console.WriteLine("\nThông tin các hộ dân:");
            khuPho.HienThiThongTin();

            Console.WriteLine("\nHộ gia đình có số con trai >= 2:");
            khuPho.TimHoConTraiNhieu(2);

            Console.WriteLine("\nHộ gia đình có số thành viên từ 5 đến 10:");
            khuPho.TimHoSoThanhVien(5, 10);

            Console.WriteLine($"\nTổng số thành viên trong khu phố: {khuPho.TinhTongSoThanhVien()}");
            Console.WriteLine("\nCác hộ gia đình có người tên 'Hùng':");
            khuPho.TimHoGiaDinhCoNguoiTenHung();

            Console.WriteLine("\nThống kê số con nam, nữ trong khu phố:");
            khuPho.ThongKeSoConNamNu();
        }
    }
}
