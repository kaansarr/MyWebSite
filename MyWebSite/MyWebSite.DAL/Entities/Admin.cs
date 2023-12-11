using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL.Entities
{
    [Table("Admin")]
    public class Admin
    {
        public int ID { get; set; }


        [StringLength(30), Column(TypeName ="varchar(30)"), Required(ErrorMessage = " Yetkil Adı Boş Geçilemez"), Display(Name = "Yetkili Adı")]

        public string Name { get; set; }

        [StringLength(30), Column(TypeName = "varchar(30)"), Required(ErrorMessage = " Yetkil Soyadı Boş Geçilemez"), Display(Name = "Yetkili Soyadı")]

        public string Surname { get; set; }

        [StringLength(30), Column(TypeName = "varchar(30)"), Required(ErrorMessage = " Kullanıcı Adı Boş Geçilemez"), Display(Name = "Kullanıcı Adı")]

        public string Username { get; set; }

        [StringLength(32), Column(TypeName = "varchar(32)"), Display(Name = "Şifre")]

        public string Password { get; set; }

    }
}
