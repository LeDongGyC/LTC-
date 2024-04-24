using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.EF
{
    [Table("tb_PhongBan")]
    public class PhongBan
    {
        public PhongBan()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }
        public virtual CongTy CongTy { get; set; }

    }
}