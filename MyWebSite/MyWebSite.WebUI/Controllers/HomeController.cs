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

        
        public HomeController( IRepository<Yeteneklerim> _repoYeteneklerim,IRepository<Hakkimda> _repoHakkimda, IRepository<Egitim> _repoEgitimlerim  )
        {
            repoEgitimlerim = _repoEgitimlerim;
            repoYeteneklerim = _repoYeteneklerim;
            repoHakkimda= _repoHakkimda;
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Egitimlerim = repoEgitimlerim.GetAll(),
                Hakkimda = repoHakkimda.GetAll(),
                Yeteneklerim=repoYeteneklerim.GetAll(),
                
            };
            return View(indexVM);
        }
    }
}
