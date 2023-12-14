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

		[Route("admin/hakkimda/yeni"),HttpPost]
		public IActionResult New(Hakkimda model)
		{
            repoHakkimda.Add(model);
            return Redirect("/admin/hakkimda");
			
		}

		[Route("admin/hakkimda/sil")]
		public IActionResult Delete(int id)
		{
			Hakkimda hakkimda = repoHakkimda.GetBy(x=>x.ID==id) ?? null ;
			if(hakkimda!=null) repoHakkimda.Delete(hakkimda);

			return Redirect("/admin/hakkimda");

		}
	}
}
