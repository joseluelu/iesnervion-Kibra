<<<<<<< HEAD
﻿using System;
=======
﻿using Proyecto_kibra.Models;
using System;
>>>>>>> refs/remotes/JMGuisadoG/master
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
using Entidades;
=======
using CapaDal_kibra;
>>>>>>> refs/remotes/JMGuisadoG/master

namespace Proyecto_kibra.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/

<<<<<<< HEAD
        public ActionResult Detalles()
        {
            Entidades.Login l = (Entidades.Login)Session["usuario"];
            Empleado empleado = l.Empleado;
            return View(empleado);
=======
        public ActionResult Nuevo()
        {
            EmpleadoModel modelo = new EmpleadoModel();

            ProvinciaDal helperProvincia = new ProvinciaDal();
            modelo.Provincias = helperProvincia.getListaProvincias();

            PuestoDal helperPuesto = new PuestoDal();
            modelo.Puestos = helperPuesto.getListaPuestos();

            DepartamentoDal helperDepartamento = new DepartamentoDal();
            modelo.Departamentos = helperDepartamento.getListaDepartamentos();

            CiudadDal helperCiudad = new CiudadDal();
            modelo.Ciudades = helperCiudad.getListaCiudades();

            return View(modelo);
>>>>>>> refs/remotes/JMGuisadoG/master
        }

    }
}
