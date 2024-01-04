using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.BL.Repositories;
using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{

    [Area("admin"),Authorize]
    public class ProjePictureController : Controller
    {
        IRepository<ProjePicture> repoProjePicture;

        public ProjePictureController(IRepository<ProjePicture> _repoProjePicture)
        {
            repoProjePicture = _repoProjePicture;
        }

        [Route("admin/projePicture")]
        public IActionResult Index(int projeid)
        {
			ViewBag.ProjeID = projeid;
            return View(repoProjePicture.GetAll(x=>x.ProjeID==projeid));
        }

		[Route("admin/projePicture/yeni")]
		public IActionResult New(int projeid)
		{
			ViewBag.ProjeID = projeid;

			return View();
		}

		[Route("admin/projePicture/yeni"),HttpPost]
		public async Task <IActionResult> New(ProjePicture model)
		{

			if (Request.Form.Files.Any())
			{
				if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory
					(), "wwwroot", "img", "projePicture"))) Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory
					(), "wwwroot", "img", "projePicture"));

				string dosyaAdi = (DateTime.Now.Minute + DateTime.Now.Millisecond) + Request.Form.Files["SubPicture"].FileName;
				using (FileStream stream=new FileStream(Path.Combine(Directory.GetCurrentDirectory
					(), "wwwroot", "img", "projePicture",dosyaAdi),FileMode.Create))
				{
					await Request.Form.Files["SubPicture"].CopyToAsync(stream);
				}
				model.SubPicture = "/img/projePicture/" + dosyaAdi;
			}

            await repoProjePicture.Add(model);
            return RedirectToAction("Index", "ProjePicture", new { projeid =model.ProjeID});
			
		}
		[Route("admin/projePicture/duzenle")]
		public IActionResult Edit(int id)
		{
			return View(repoProjePicture.GetBy(x=>x.ID==id));
		}

		[Route("admin/projePicture/duzenle"), HttpPost]
		public async Task<IActionResult> Edit(ProjePicture model)
		{

			if (Request.Form.Files.Any())
			{
				if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory
					(), "wwwroot", "img", "projePicture"))) Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory
					(), "wwwroot", "img", "projePicture"));

				string dosyaAdi = (DateTime.Now.Minute + DateTime.Now.Millisecond) + Request.Form.Files["Picture"].FileName;
				using (FileStream stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory
					(), "wwwroot", "img", "projePicture", dosyaAdi), FileMode.Create))
				{
					await Request.Form.Files["Picture"].CopyToAsync(stream);
				}
				model.SubPicture = "/img/projePicture/" + dosyaAdi;
			}

			await repoProjePicture.Update(model);
			return RedirectToAction("Index", "ProjePicture", new { projeid = model.ProjeID });


		}

		[Route("/admin/projePicture/sil"), HttpPost]
		public async Task<string> Delete(int id)
		{
			try
			{
				ProjePicture projePicture = repoProjePicture.GetBy(x => x.ID == id) ?? null;
				if (projePicture != null) await repoProjePicture.Delete(projePicture);
				return "OK";
			}
			catch (Exception ex)
			{

				return ex.Message;

			}


		}
	}
}
