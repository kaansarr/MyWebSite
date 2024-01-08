using MyWebSite.DAL.Entities;

namespace MyWebSite.WebUI.ViewModel
{
    public class ProjeDetailViewModel
    {
        public Proje Proje { get; set; }
        public IEnumerable<ProjePicture> ProjePictures { get; set; }

    }
}
