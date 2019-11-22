using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using image.Models;

namespace image.Controllers
{
    public class HomeController : Controller
    {
        imageEntities imgdb = new imageEntities();
        fileimageEntities fimg = new fileimageEntities();
        public ActionResult Index()
        {
            return RedirectToAction("Image");
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
        public ActionResult Image()
        {
            return View(imgdb.imgs.ToList());
        }
        [HttpPost]
        public ActionResult Image(HttpPostedFileBase postedFile)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }

            imgdb.imgs.Add(new img
            {
                Name = Path.GetFileName(postedFile.FileName),
                ContentType = postedFile.ContentType,
                data = bytes
            });
            imgdb.SaveChanges();
            return RedirectToAction("Image");
        }
        public ActionResult Image1()
        {
            return View(fimg.imgups.ToList());
        }
        [HttpPost]
        public ActionResult Image1(HttpPostedFileBase postedFile)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(postedFile.InputStream))
            {
                bytes = br.ReadBytes(postedFile.ContentLength);
            }

            fimg.imgups.Add(new imgup
            {
                Name = Path.GetFileName(postedFile.FileName),
                ContentType = postedFile.ContentType,
                Image = bytes
            });
            fimg.SaveChanges();
            return RedirectToAction("Image1");
        }

    }
}