using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modelos;
namespace TI_Web.Areas.Seguridad.Controllers
{
    public class MainController : Controller
    {
        // GET: Seguridad/Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesion()
        {
            String correo = Request.Form["correo"];
            String clave = Request.Form["clave"];
            try
            {
                Usuario user = UsuarioTI.IniciarSesion(correo, clave);
                if (user.Rol == "Administrador")
                {
                    Session["Administrador"] = user;
                    return RedirectToAction("Index");
                }
                else if (user.Rol == "Estudiante")
                {
                    Session["estudiante"] = user;
                    return RedirectToAction("Index");
                }
                else if (user.Rol == "Profesor")
                {
                    Session["Administrador"] = user;
                    return RedirectToAction("Index");
                }
                else
                {
                    Session["Usuario"] = user;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");

            }
        } 
    }
}