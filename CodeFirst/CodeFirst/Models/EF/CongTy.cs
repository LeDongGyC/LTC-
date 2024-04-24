using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.EF
{
    [Table("tb_CongTy")]
    public class CongTy
    {
        public CongTy()
        {
            this.PhongBans = new HashSet<PhongBan>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CompanyName { get; set; }
       public ICollection<PhongBan> PhongBans { get; set; } 
    }
}