using GoldFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldFinal.Controllers
{
    public class HomeController : Controller
    {
        private Skill db = new Skill();

        public ActionResult ChildAction()
        {
            var model = new List<GoldModels>();
            var list = db.AccountBook.ToList();

            foreach (var item in list)
            {
                var coin = new GoldModels();
                if (item.Categoryyy == 1)
                {
                    coin.Sort = "支出";
                }
                else coin.Sort = "收入";

                coin.Cash = item.Amounttt;
                coin.Date = item.Dateee;
                coin.Remark = item.Remarkkk;

                if (item.Remarkkk.Length > 100)
                {
                    coin.Remark = item.Remarkkk.Substring(0, 99);
                }
                else
                {
                    coin.Remark = item.Remarkkk;
                }

                model.Add(coin);
            }

            return View(model.OrderBy(d => d.Date).ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountBook)
        {
            if (ModelState.IsValid)
            {
                accountBook.Id = Guid.NewGuid();
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountBook);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}