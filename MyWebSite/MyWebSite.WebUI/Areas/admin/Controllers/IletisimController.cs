using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{

    [Area("admin"),Authorize]
    public class IletisimController : Controller
    {
        IRepository<Iletisim> repoIletisim;

        public IletisimController(IRepository<Iletisim> _repoIletisim)
        {
            repoIletisim = _repoIletisim;
        }

        [Route("admin/iletisim")]
        public IActionResult Index()
        {
            return View(repoIletisim.GetAll());
        }

		[Route("admin/iletisim/yeni")]
		public IActionResult New()
		{
			return View();
		}

		
		

		

		[Route("/admin/iletisim/sil"), HttpPost]
		public async Task<string> Delete(int id)
		{
			try
			{
				Iletisim iletisim = repoIletisim.GetBy(x => x.ID == id) ?? null;
				if (iletisim != null) await repoIletisim.Delete(iletisim);
				return "OK";
			}
			catch (Exception ex)
			{

				return ex.Message;

			}


		}
	}
}
