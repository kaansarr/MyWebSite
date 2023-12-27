using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{

    [Area("admin"),Authorize]
    public class ProjeController : Controller
    {
        IRepository<Proje> repoProje;

        public ProjeController(IRepository<Proje> _repoProje)
        {
            repoProje = _repoProje;
        }

        [Route("admin/proje")]
        public IActionResult Index()
        {
            return View(repoProje.GetAll());
        }

		[Route("admin/proje/yeni")]
		public IActionResult New()
		{
			return View();
		}

		[Route("admin/proje/yeni"),HttpPost]
		public async Task <IActionResult> New(Proje model)
		{
           await repoProje.Add(model);
            return Redirect("/admin/proje");
			
		}
		[Route("admin/proje/duzenle")]
		public IActionResult Edit(int id)
		{
			return View(repoProje.GetBy(x=>x.ID==id));
		}

		[Route("admin/proje/duzenle"), HttpPost]
		public async Task<IActionResult> Edit(Proje model)
		{
			await repoProje.Update(model);
			return Redirect("/admin/proje");

		}

		[Route("/admin/proje/sil"), HttpPost]
		public async Task<string> Delete(int id)
		{
			try
			{
				Proje proje = repoProje.GetBy(x => x.ID == id) ?? null;
				if (proje != null) await repoProje.Delete(proje);
				return "OK";
			}
			catch (Exception ex)
			{

				return ex.Message;

			}


		}
	}
}
