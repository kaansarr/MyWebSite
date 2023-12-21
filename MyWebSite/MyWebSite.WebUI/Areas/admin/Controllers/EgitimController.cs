using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{

    [Area("admin"),Authorize]
    public class EgitimController : Controller
    {
        IRepository<Egitim> repoEgitim;

        public EgitimController(IRepository<Egitim> _repoEgitim)
        {
            repoEgitim = _repoEgitim;
        }

        [Route("admin/egitim")]
        public IActionResult Index()
        {
            return View(repoEgitim.GetAll());
        }

		[Route("admin/egitim/yeni")]
		public IActionResult New()
		{
			return View();
		}

		[Route("admin/egitim/yeni"),HttpPost]
		public async Task <IActionResult> New(Egitim model)
		{
           await repoEgitim.Add(model);
            return Redirect("/admin/egitim");
			
		}
		[Route("admin/egitim/duzenle")]
		public IActionResult Edit(int id)
		{
			return View(repoEgitim.GetBy(x=>x.ID==id));
		}

		[Route("admin/egitim/duzenle"), HttpPost]
		public async Task<IActionResult> Edit(Egitim model)
		{
			await repoEgitim.Update(model);
			return Redirect("/admin/egitim");

		}

		[Route("/admin/egitim/sil"), HttpPost]
		public async Task<string> Delete(int id)
		{
			try
			{
				Egitim egitim = repoEgitim.GetBy(x => x.ID == id) ?? null;
				if (egitim != null) await repoEgitim.Delete(egitim);
				return "OK";
			}
			catch (Exception ex)
			{

				return ex.Message;

			}


		}
	}
}
