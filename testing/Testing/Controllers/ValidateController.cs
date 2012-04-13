using System;
using System.Web.Mvc;
using System.Web.UI;

namespace Testing.Controllers
{
    public class ValidateController : Controller
    {
        [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
        public JsonResult Later(DateTime? later, DateTime? earlier)
        {
            var valid = later > earlier;
            return Json(valid, JsonRequestBehavior.AllowGet);
        }
    }
}