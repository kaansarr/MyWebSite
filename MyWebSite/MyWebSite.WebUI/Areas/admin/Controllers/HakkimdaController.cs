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
		public async Task <IActionResult> New(Hakkimda model)
		{
           await repoHakkimda.Add(model);
            return Redirect("/admin/hakkimda");
			
		}
		[Route("admin/hakkimda/duzenle")]
		public IActionResult Edit(int id)
		{
			return View(repoHakkimda.GetBy(x=>x.ID==id));
		}

		[Route("admin/hakkimda/duzenle"), HttpPost]
		public async Task<IActionResult> Edit(Hakkimda model)
		{
			await repoHakkimda.Update(model);
			return Redirect("/admin/hakkimda");

		}

		[Route("/admin/hakkimda/sil"), HttpPost]
		public async Task<string> Delete(int id)
		{
			try
			{
				Hakkimda hakkimda = repoHakkimda.GetBy(x => x.ID == id) ?? null;
				if (hakkimda != null) await repoHakkimda.Delete(hakkimda);
				return "OK";
			}
			catch (Exception ex)
			{

				return ex.Message;

			}


		}
	}
}
