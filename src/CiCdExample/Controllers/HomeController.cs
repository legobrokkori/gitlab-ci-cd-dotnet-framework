using System.Web.Mvc;
using ClassLibrary1;

namespace CiCdExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var node = new ListNode();

            return View();
        }
    }
}
