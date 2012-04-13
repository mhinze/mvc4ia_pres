using System.Web.Mvc;

namespace Testing.Controllers
{
    public class FunctionalTestFixturesController : Controller
    {
        public ViewResult Later()
        {
            // this action/view sets up the UI for testing
        
        	return View();
        }
    }
}