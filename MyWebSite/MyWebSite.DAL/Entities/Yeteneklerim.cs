using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DAL.Entities
{
    public class Yeteneklerim
    {
        public int ID { get; set; }

        [StringLength(50), Column(TypeName = "nvarchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Başlık")]
        public string Baslik { get; set; }
    }
}
