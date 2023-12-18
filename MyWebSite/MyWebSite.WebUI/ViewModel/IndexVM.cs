using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.ViewModel
{
	public class IndexVM
	{
		public IEnumerable  <Hakkimda> Hakkimda { get; set; }
		public IEnumerable  <Yeteneklerim> Yeteneklerim { get; set; }
	}
}
