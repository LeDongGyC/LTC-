using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DanhMuc
    {
        public int Id { get; set; }
        public string TenDM { get; set; }
        public DanhMuc(int id, string tenDM)
        {
            Id = id;
            TenDM = tenDM;
        }
        public static List<DanhMuc> GetDanhMucs()
        {
            List<DanhMuc> danhMucs = new List<DanhMuc>
        {
            new DanhMuc(1, "Sách"),
            new DanhMuc(2, "Tạp chí"),
            new DanhMuc(3, "Báo"),
        };

            return danhMucs;
        }
    }
}
