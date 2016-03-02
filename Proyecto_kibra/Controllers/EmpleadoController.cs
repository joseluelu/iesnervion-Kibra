using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;

namespace Proyecto_kibra.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/

        public ActionResult Detalles()
        {
            Entidades.Login l = (Entidades.Login)Session["usuario"];
            Empleado empleado = l.Empleado;
            return View(empleado);
        }

    }
}
