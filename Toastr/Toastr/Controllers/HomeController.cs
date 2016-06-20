using System.Web.Mvc;
using Toastr.Helper;

namespace Toastr.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            AddToastMessage("Congratulations", "You made it all the way here!", ToastType.Success);
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