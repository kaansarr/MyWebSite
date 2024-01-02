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
	public class Iletisim
	{
		public int ID { get; set; }

		[StringLength(50), Column(TypeName = "nvarchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Ad")]

		public string Ad { get; set; }

		[StringLength(50), Column(TypeName = "nvarchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Soyad")]

		public string Soyad { get; set; }

		[StringLength(100), Column(TypeName = "nvarchar(100)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Konu")]

		public string Konu { get; set; }

		[Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Mesaj")]

		public string Mesaj { get; set; }
	}
}
