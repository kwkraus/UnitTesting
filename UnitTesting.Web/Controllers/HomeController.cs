using System.Web.Mvc;
using UnitTesting.Services;

namespace UnitTesting.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParcelService _parcelSvc;

        public HomeController(IParcelService parcelSvc)
        {
            _parcelSvc = parcelSvc;
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

        public ActionResult Parcel()
        {
            ViewBag.Message = "Your Parcel page.";

            return View(_parcelSvc.GetParcel(1));
        }
    }
}