using System.Web.Mvc;

namespace CMSdemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult CaseList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoadMoreIcons()
        {

            ViewBag.arrowClick = true;
            return Content("ok");

        }

        public ActionResult LoadMainIcons()
        {

            ViewBag.arrowClick = false;
            return PartialView("mainIconsPartial");
            //            return PartialView("moreIconsPartial");

        }
    }
}
