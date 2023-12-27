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
	public class Proje
	{
		public int ID { get; set; }

		[StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Proje Adı")]
		public string Name { get; set; }

		[StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Proje Resmi")]
		public string Picture { get; set; }

		[StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Bağlantı Linki")]
		public string Link { get; set; }
		[StringLength(150), Column(TypeName = "varchar(150)"), Display(Name = "Bağlantı Linki2")]

		public string Link2 { get; set; }
	}
}
