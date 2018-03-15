using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KdgApplication.Models;

namespace KdgApplication.Controllers
{
    public partial class TextController : Controller
    {
        // GET: Text
        public virtual ActionResult Index()
        {
            var model = new AddTextModel();
            return View(model);
        }
        [HttpPost]
        public virtual ActionResult Index(AddTextModel model)
        {
            //using (var db = new TextSentimentDbContext())
            //{
            //    db.TextAnalyses.Add(new TextAnalysis()
            //    {
            //        Title = model.Title,
            //        TextContent = model.Text
            //    });
            //    db.SaveChanges();
            //}
            return RedirectToAction(MVC.Home.Index());
        }
    }
}