using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.ViewModel
{
	public class IndexVM
	{
		public IEnumerable  <Hakkimda> Hakkimda { get; set; }
		public IEnumerable  <Yeteneklerim> Yeteneklerim { get; set; }
		public IEnumerable  <Egitim> Egitimlerim { get; set; }
		public IEnumerable  <Proje> Projelerim { get; set; }

		
	}
}
