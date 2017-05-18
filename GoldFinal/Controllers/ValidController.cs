using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldFinal.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult OverToday (DateTime? Dateee)
        {
            var result = true;
            if (Dateee.HasValue)
            {
                result = Dateee.Value < DateTime.Now.Date;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}