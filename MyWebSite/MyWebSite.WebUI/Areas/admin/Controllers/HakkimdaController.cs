using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{

    [Area("admin"),Authorize]
    public class HakkimdaController : Controller
    {
        IRepository<Hakkimda> repoHakkimda;

        public HakkimdaController(IRepository<Hakkimda> _repoHakkimda)
        {
            repoHakkimda = _repoHakkimda;
        }

        [Route("admin/hakkimda")]
        public IActionResult Index()
        {
            return View(repoHakkimda.GetAll());
        }

		[Route("admin/hakkimda/yeni")]
		public IActionResult New()
		{
			return View();
		}
	}
}
