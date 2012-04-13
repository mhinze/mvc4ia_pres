using System.Web.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}