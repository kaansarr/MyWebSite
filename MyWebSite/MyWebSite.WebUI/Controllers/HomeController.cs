using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;
using MyWebSite.WebUI.ViewModel;

namespace MyWebSite.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Hakkimda> repoHakkimda;

        public HomeController(IRepository<Hakkimda> _repoHakkimda)
        {
            repoHakkimda= _repoHakkimda;
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Hakkimda = repoHakkimda.GetAll()
            };
            return View(indexVM);
        }
    }
}
