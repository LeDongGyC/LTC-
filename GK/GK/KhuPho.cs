using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK
{
    class KhuPho
    {
        public List<HoGiaDinh> DanhSachHoGiaDinh { get; set; }

        public KhuPho()
        {
            DanhSachHoGiaDinh = new List<HoGiaDinh>();
        }

        public void ThemHoGiaDinh(HoGiaDinh hoGiaDinh)
        {
            DanhSachHoGiaDinh.Add(hoGiaDinh);
        }

        public void HienThiThongTin()
        {
            foreach (var hoGiaDinh in DanhSachHoGiaDinh)
            {
                Console.WriteLine($"Số nhà: {hoGiaDinh.SoNha}");
                Console.WriteLine($"Số thành viên: {hoGiaDinh.SoThanhVien}");
                Console.WriteLine($"Số con trai: {hoGiaDinh.SoConTrai}");
                Console.WriteLine($"Số con gái: {hoGiaDinh.SoConGai}");
                Console.WriteLine("Danh sách người:");
                foreach (var nguoi in hoGiaDinh.DanhSachNguoi)
                {
                    Console.WriteLine($"\tHọ tên: {nguoi.HoTen}, Tuổi: {nguoi.Tuoi}, Nghề nghiệp: {nguoi.NgheNghiep}, Số CMND: {nguoi.SoCMND}");
                }
                Console.WriteLine();
            }
        }

        public void TimHoConTraiNhieu(int soConTrai)
        {
            foreach (var hoGiaDinh in DanhSachHoGiaDinh)
            {
                if (hoGiaDinh.SoConTrai >= soConTrai)
                {
                    Console.WriteLine($"Số nhà: {hoGiaDinh.SoNha}");
                }
            }
        }
        public void TimHoSoThanhVien(int tuSo, int denSo)
        {
            foreach (var hoGiaDinh in DanhSachHoGiaDinh)
            {
                if (hoGiaDinh.SoThanhVien >= tuSo && hoGiaDinh.SoThanhVien <= denSo)
                {
                    Console.WriteLine($"Số nhà: {hoGiaDinh.SoNha}");
                }
            }
        }

        public int TinhTongSoThanhVien()
        {
            int tong = 0;
            foreach (var hoGiaDinh in DanhSachHoGiaDinh)
            {
                tong += hoGiaDinh.SoThanhVien;
            }
            return tong;
        }
        public void TimHoGiaDinhCoNguoiTenHung()
        {
            var hoGiaDinhCoNguoiTenHung = DanhSachHoGiaDinh.Where(ho => ho.DanhSachNguoi.Any(nguoi => nguoi.HoTen.Contains("Hùng")));
            foreach (var hoGiaDinh in hoGiaDinhCoNguoiTenHung)
            {
                Console.WriteLine($"Số nhà: {hoGiaDinh.SoNha}");
            }
        }

        public void ThongKeSoConNamNu()
        {
            int tongConNam = 0;
            int tongConNu = 0;
            foreach (var hoGiaDinh in DanhSachHoGiaDinh)
            {
                tongConNam += hoGiaDinh.SoConTrai;
                tongConNu += hoGiaDinh.SoConGai;
            }
            Console.WriteLine($"Tổng số con nam: {tongConNam}");
            Console.WriteLine($"Tổng số con nữ: {tongConNu}");
        }
    }
    }
