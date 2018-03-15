using System.Linq;
using System.Web.Mvc;
using KdgApplication.Core.TestData;
using KdgApplication.Models;

namespace KdgApplication.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var model = new HomeIndexViewModel();

            model.TextCards = Texts.TestData.ToList();

            return View(model);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}