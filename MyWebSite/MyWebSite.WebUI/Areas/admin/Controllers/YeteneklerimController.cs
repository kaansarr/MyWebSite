using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{

    [Area("admin"),Authorize]
    public class YeteneklerimController : Controller
    {
        IRepository<Yeteneklerim> repoYeteneklerim;

        public YeteneklerimController(IRepository<Yeteneklerim> _repoYeteneklerim)
        {
            repoYeteneklerim = _repoYeteneklerim;
        }

        [Route("admin/yeteneklerim")]
        public IActionResult Index()
        {
            return View(repoYeteneklerim.GetAll());
        }

		[Route("admin/yeteneklerim/yeni")]
		public IActionResult New()
		{
			return View();
		}

		[Route("admin/yeteneklerim/yeni"),HttpPost]
		public async Task <IActionResult> New(Yeteneklerim model)
		{
           await repoYeteneklerim.Add(model);
            return Redirect("/admin/yeteneklerim");
			
		}
		[Route("admin/yeteneklerim/duzenle")]
		public IActionResult Edit(int id)
		{
			return View(repoYeteneklerim.GetBy(x=>x.ID==id));
		}

		[Route("admin/yeteneklerim/duzenle"), HttpPost]
		public async Task<IActionResult> Edit(Yeteneklerim model)
		{
			await repoYeteneklerim.Update(model);
			return Redirect("/admin/yeteneklerim");

		}

		[Route("/admin/yeteneklerim/sil"), HttpPost]
		public async Task<string> Delete(int id)
		{
			try
			{
				Yeteneklerim yeteneklerim = repoYeteneklerim.GetBy(x => x.ID == id) ?? null;
				if (yeteneklerim != null) await repoYeteneklerim.Delete(yeteneklerim);
				return "OK";
			}
			catch (Exception ex)
			{

				return ex.Message;

			}


		}
	}
}
