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
	public class Egitim
	{
		public int ID { get; set; }

		[StringLength(50), Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Okul")]
		public string Okul { get; set; }


		[StringLength(50), Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Fakülte")]


		public string Fakulte { get; set; }

		[StringLength(50), Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Bölüm")]

		public string Bolum { get; set; }

		[StringLength(50), Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Boş Geçilemez"), Display(Name = "Tarih")]

		public string Tarih { get; set; }

	}
}
