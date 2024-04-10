using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK
{
    class HoGiaDinh
    {
        public int SoThanhVien { get; set; }
        public int SoConTrai { get; set; }
        public int SoConGai => SoThanhVien - SoConTrai;
        public int SoNha { get; set; }
        public List<Nguoi> DanhSachNguoi { get; set; }
    }
}
