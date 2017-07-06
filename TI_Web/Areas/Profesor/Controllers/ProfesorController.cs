using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modelos;
namespace TI_Web.Areas.Profesor.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor/Profesor
        public ActionResult Index()
        {
            ViewBag.ListadoProfesores = ProfesorTi.ListaProfesor();
            return View();
        }

    }
}