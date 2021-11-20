using fileupload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fileupload.Controllers
{
    public class FileUController : Controller
    {
        // GET: FileU
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Imagen imagen )
        {

            _ = imagen.file;



            String ruta = Server.MapPath("~/img/");
            ruta += imagen.file.FileName;

            imagen.file.SaveAs(ruta);

            return View();
        }

        public ActionResult Second() {

            return View();
        }
    }
}