using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppWeb.Models;
using AppWeb.Models.Tablas;
using AppWeb.Models.Modelos;

namespace AppWeb.Controllers
{
    public class AlumnosAdminController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            List<TablaAlumnos> lst = null;
            using (ColegioEntities db = new ColegioEntities())
            {
                           lst = (from d in db.Alumnos
                           select new TablaAlumnos
                           {
                               Id = d.Id_Alumno,
                               Nombre1 = d.Primer_Nombre,
                               Nombre2 = d.Segundo_Nombre,
                               Apellido1 = d.Primer_Apellido,
                               Apellido2 = d.Segundo_Apellido,
                               Identificacion = (decimal)d.Identificacion,
                               Telefono = (decimal)d.Telefono,
                               Usuario = d.Usuarios.Nombre_Usuario
                           }).ToList();
                
            }
            return View(lst);
        }
    }
}