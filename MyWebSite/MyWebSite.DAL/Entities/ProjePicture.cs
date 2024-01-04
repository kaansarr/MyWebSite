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
	public class ProjePicture
	{
		public int ID { get; set; }

		[StringLength(150), Column(TypeName = "nvarchar(150)"), Display(Name = "Proje Resim Adı")]
		public string Name { get; set; }

		[StringLength(150), Column(TypeName = "nvarchar(150)"), Display(Name = "Proje Resmi")]
		public string SubPicture { get; set; }
		[Display(Name="Görüntülenme Sırası")]
		public int DisplayIndex { get; set; }

		public int ProjeID { get; set; }
		public Proje Proje { get; set; }
		
	}
}
