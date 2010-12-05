using System.Web.Mvc;

namespace StudiesPlansWeb.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Witaj w serwisie Plany Studiów";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
