using System.Configuration;
using System.Web.Mvc;

namespace keyvault_netfw_web_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}