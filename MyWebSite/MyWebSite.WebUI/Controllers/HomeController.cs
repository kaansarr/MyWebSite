using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Contexts;
using MyWebSite.DAL.Entities;
using MyWebSite.WebUI.ViewModel;

using System.Linq;


namespace MyWebSite.WebUI.Controllers
{
	public class HomeController : Controller
	{
		IRepository<Hakkimda> repoHakkimda;
		IRepository<Yeteneklerim> repoYeteneklerim;
		IRepository<Egitim> repoEgitimlerim;
		IRepository<Iletisim> repoIletisim;
		IRepository<Proje> repoProje;
		IRepository<ProjePicture> repoProjePicture;
		SqlContext db;


		public HomeController(IRepository<Yeteneklerim> _repoYeteneklerim, IRepository<Hakkimda> _repoHakkimda, IRepository<Egitim> _repoEgitimlerim, IRepository<Iletisim> _repoIletisim, IRepository<Proje> _repoProje, IRepository<ProjePicture> _repoProjePicture, SqlContext db)
		{
			repoEgitimlerim = _repoEgitimlerim;
			repoYeteneklerim = _repoYeteneklerim;
			repoHakkimda = _repoHakkimda;
			repoIletisim = _repoIletisim;
			repoProje = _repoProje;
			repoProjePicture = _repoProjePicture;
			this.db = db;
		}
		public IActionResult Index()
		{
			IndexVM indexVM = new IndexVM
			{
				Egitimlerim = repoEgitimlerim.GetAll().OrderBy(o => o.ID).ToList()
,
				Hakkimda = repoHakkimda.GetAll(),
				Yeteneklerim = repoYeteneklerim.GetAll(),
				//Projelerim = repoProje.GetAll()


			};
			indexVM.Projelerim = db.Projelerim.Include(x=>x.ProjePictures).ToList();

			return View(indexVM);
		}
		[HttpGet]
		public PartialViewResult Iletisim()
		{
			return PartialView();
		}


		[HttpPost]
		public async Task<IActionResult> Iletisim(Iletisim t)
		{
			await repoIletisim.Add(t);
			return Redirect("/");
		}

	










	}
}
