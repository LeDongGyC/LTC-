using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.EF
{
    [Table("tb_NhanVien")]

    public class NhanVien
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FullName { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        public virtual PhongBan PhongBan { get; set; }

    }
}