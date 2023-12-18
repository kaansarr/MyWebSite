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

        public HomeController(IRepository<Hakkimda> _repoHakkimda, IRepository<Yeteneklerim> _repoYeteneklerim)
        {
            repoHakkimda = _repoHakkimda;
            repoYeteneklerim = _repoYeteneklerim;
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Hakkimda = repoHakkimda.GetAll(),
                Yeteneklerim=repoYeteneklerim.GetAll(),
                
            };
            return View(indexVM);
        }
    }
}
