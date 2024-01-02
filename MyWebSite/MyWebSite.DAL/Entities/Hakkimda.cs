using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL.Entities
{
    public class Hakkimda
    {
        public int ID { get; set; }
        [StringLength(50),Column(TypeName = "nvarchar(50)"),Required(ErrorMessage ="Boş Geçilemez"),Display(Name ="Başlık")]
        public string Baslik { get; set; }


        [StringLength(500), Column(TypeName = "nvarchar(500)"),Display(Name ="Açıklama")]

        public string Aciklama { get; set; }

    }
}
