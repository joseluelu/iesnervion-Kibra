﻿using System;
﻿using Proyecto_kibra.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using CapaDal_kibra;

namespace Proyecto_kibra.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/

        public ActionResult Detalles(int id)
        {
            Empleado empleado;
            
                
           
                EmpleadoDal helper = new EmpleadoDal();
                empleado = helper.getEmpleadoPorId(id);
          

            return View(empleado);
        }

        public ActionResult Nuevo()
        {
            EmpleadoModel modelo = new EmpleadoModel();

            ProvinciaDal helperProvincia = new ProvinciaDal();
            modelo.Provincias = helperProvincia.getListaProvincias();

            PuestoDal helperPuesto = new PuestoDal();
            modelo.Puestos = helperPuesto.getListaPuestos();

            DepartamentoDal helperDepartamento = new DepartamentoDal();
            modelo.Departamentos = helperDepartamento.getListaDepartamentos();



            return View(modelo);
        }

        public ActionResult Listado()
        {
            EmpleadoDal helper = new EmpleadoDal();
            List<Empleado> listado = helper.getListaEmpleados();
            return View(listado);
        }

    }
}
