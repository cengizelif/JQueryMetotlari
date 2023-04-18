using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryMetotlari.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        private static List<string> liste = new List<string>() { "Teknoloji", "Gıda", "Giyim", "Sağlık" };
      
        
        public PartialViewResult VerileriGetir(string veri="")
        {
            if(string.IsNullOrEmpty(veri)==false)
            {
                liste.Add(veri);
            }
            System.Threading.Thread.Sleep(2000);
            return PartialView("_PartialPageListe",liste);
        }

        public JsonResult VerileriGetir2(string veri = "")
        {
            if (string.IsNullOrEmpty(veri) == false)
            {
                liste.Add(veri);
            }
            System.Threading.Thread.Sleep(2000);
            return Json(liste, JsonRequestBehavior.AllowGet);   
            //["Teknoloji","Giyim"]
        }

        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index4()
        {
            return View();
        }

        [HttpPost]
        public JsonResult DosyaYukle(HttpPostedFileBase  file)
        {
            if(file!=null)
            {
                if(Directory.Exists(Server.MapPath("~/file"))==false)
                {
                    Directory.CreateDirectory(Server.MapPath("~/file"));
                }

                file.SaveAs(Path.Combine(Server.MapPath("~/file"), file.FileName));
                return Json(new { hata = false , mesaj="Dosya yüklendi"});
            }

            return Json(new {hata=true, mesaj = "Dosya yüklenemedi" });
        }

        public ActionResult Index5()
        {
            return View();
        }
        public ActionResult Index6()
        {
            return View();
        }
    }
}