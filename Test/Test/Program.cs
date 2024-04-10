using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static List<TaiLieu> taiLieus = new List<TaiLieu>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Thêm mới danh sách bao, tạp chí, sách");
                Console.WriteLine("2. Tìm theo từng loại sách");
                Console.WriteLine("3. Tìm báo có ngày phát hành sau 24/3/2024");
                Console.WriteLine("4. Thoát");

                Console.Write("Chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ThemMoiTaiLieu();
                        break;
                    case 2:
                        TimTheoLoaiSach();
                        break;
                    case 3:
                        TimBaoSauNgay();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
        static void ThemMoiTaiLieu()
        {
            Console.WriteLine("Chọn loại tài liệu muốn thêm:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");

            Console.Write("Chọn loại: ");
            int choice = int.Parse(Console.ReadLine());

            TaiLieu taiLieu = null;

            Console.Write("Nhập mã xuất bản: ");
            string maXB = Console.ReadLine();

            Console.Write("Nhập tên danh mục: ");
            string tenDM = Console.ReadLine();

            Console.Write("Nhập nhà phát hành: ");
            string nhaPhatHanh = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    taiLieu = new Sach();
                    Console.Write("Nhập thời gian: ");
                    ((Sach)taiLieu).ThoiGian = DateTime.Parse(Console.ReadLine());
                    Console.Write("Nhập số trang: ");
                    ((Sach)taiLieu).SoTrang = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    taiLieu = new TapChi();
                    Console.Write("Nhập số phát hành: ");
                    ((TapChi)taiLieu).SoPH = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số trang phát hành: ");
                    ((TapChi)taiLieu).TrangPH = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    taiLieu = new Bao();
                    Console.Write("Nhập ngày phát hành (dd/mm/yyyy): ");
                    ((Bao)taiLieu).NgayPH = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    return;
            }

            taiLieu.MaXB = maXB;
            taiLieu.TenDM = tenDM;
            taiLieu.NhaPhatHanh = nhaPhatHanh;

            taiLieus.Add(taiLieu);
            Console.WriteLine("Thêm tài liệu thành công.");
        }
        static void TimTheoLoaiSach()
        {
            Console.WriteLine("Chọn loại sách muốn tìm:");
            Console.WriteLine("1. Sách");
            Console.WriteLine("2. Tạp chí");
            Console.WriteLine("3. Báo");

            Console.Write("Chọn loại: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var sach = taiLieus.OfType<Sach>();
                    if (sach.Any())
                    {
                        foreach (var item in sach)
                        {
                            Console.WriteLine($"Mã XB: {item.MaXB}, Tên DM: {item.TenDM}, Thời gian: {item.ThoiGian}, Số trang: {item.SoTrang}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy sách.");
                    }
                    break;
                case 2:
                    var tapChi = taiLieus.OfType<TapChi>();
                    if (tapChi.Any())
                    {
                        foreach (var item in tapChi)
                        {
                            Console.WriteLine($"Mã XB: {item.MaXB}, Tên DM: {item.TenDM}, Số phát hành: {item.SoPH}, Số trang phát hành: {item.TrangPH}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy tạp chí.");
                    }
                    break;
                case 3:
                    var bao = taiLieus.OfType<Bao>();
                    if (bao.Any())
                    {
                        foreach (var item in bao)
                        {
                            Console.WriteLine($"Mã XB: {item.MaXB}, Tên DM: {item.TenDM}, Ngày phát hành: {item.NgayPH}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy báo.");
                    }
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }

        static void TimBaoSauNgay()
        {
            var bao = taiLieus.OfType<Bao>().Where(b => b.NgayPH > new DateTime(2024, 3, 24));
            if (bao.Any())
            {
                foreach (var item in bao)
                {
                    Console.WriteLine($"Mã XB: {item.MaXB}, Tên DM: {item.TenDM}, Ngày phát hành: {item.NgayPH}");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy báo nào có ngày phát hành sau 24/3/2024.");
            }

        }
    }
}
