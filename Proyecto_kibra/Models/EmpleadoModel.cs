using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_kibra.Models
{
    public class EmpleadoModel
    {
        public Empleado Empleado { get; set; }

        public List<Provincia> Provincias { get; set; }

        public List<Ciudad> Ciudades { get; set; }

        public List<Puesto> Puestos { get; set; }

        public List<Departamento> Departamentos { get; set; }

        public int ProvinciaId { get; set; }
    }
}