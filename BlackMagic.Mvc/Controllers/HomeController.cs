using System.Web.Mvc;

namespace BlackMagic.Mvc.Controllers
{
    public class HomeController : BlackMagicController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
