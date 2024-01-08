using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
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

        
        public HomeController( IRepository<Yeteneklerim> _repoYeteneklerim,IRepository<Hakkimda> _repoHakkimda, IRepository<Egitim> _repoEgitimlerim, IRepository<Iletisim> _repoIletisim, IRepository<Proje> _repoProje, IRepository<ProjePicture> _repoProjePicture)
        {
            repoEgitimlerim = _repoEgitimlerim;
            repoYeteneklerim = _repoYeteneklerim;
            repoHakkimda= _repoHakkimda;
            repoIletisim= _repoIletisim;
            repoProje = _repoProje;
            repoProjePicture= _repoProjePicture;
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
		public async Task <IActionResult> Iletisim(Iletisim t)
		{
			await repoIletisim.Add(t);
			return Redirect("/");
		}

		[Route("/Home/DetailGallery/{id}")]
		public IActionResult DetailGallery(int id)
		{
			var viewModel = new ProjeDetailViewModel
			{
				Proje = repoProje.GetBy(o => o.ID == id),
				ProjePictures = repoProjePicture.GetAll().Where(p => p.ProjeID == id).OrderByDescending(o => o.ID).ToList()
			};

			return View(viewModel);
		}










	}
}
