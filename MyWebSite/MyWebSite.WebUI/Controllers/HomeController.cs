using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;
using MyWebSite.WebUI.ViewModel;

namespace MyWebSite.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Hakkimda> repoHakkimda;
        IRepository<Yeteneklerim> repoYeteneklerim;
        IRepository<Egitim> repoEgitimlerim;
        IRepository<Iletisim> repoIletisim;
        IRepository<Proje> repoProje;

        
        public HomeController( IRepository<Yeteneklerim> _repoYeteneklerim,IRepository<Hakkimda> _repoHakkimda, IRepository<Egitim> _repoEgitimlerim, IRepository<Iletisim> _repoIletisim, IRepository<Proje> _repoProje)
        {
            repoEgitimlerim = _repoEgitimlerim;
            repoYeteneklerim = _repoYeteneklerim;
            repoHakkimda= _repoHakkimda;
            repoIletisim= _repoIletisim;
            repoProje = _repoProje;
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Egitimlerim = repoEgitimlerim.GetAll().OrderBy(o => o.ID).ToList()
,
                Hakkimda = repoHakkimda.GetAll(),
                Yeteneklerim = repoYeteneklerim.GetAll(),
                Projelerim = repoProje.GetAll()
                
            };
            return View(indexVM);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }

		
		[HttpPost]
		public ActionResult Iletisim(Iletisim t)
		{
			repoIletisim.Add(t);
			return Redirect("/");
		}







	}
}
