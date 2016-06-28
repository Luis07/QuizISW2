using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {
        private Curriculum Lenguajes = new Curriculum();
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ViewBag.leng = Lenguaje(db.Lenguajes.ToList());
            ViewBag.exp = Proyectos(db.Proyectos.ToList());
            return View();
        }
        public string Lenguaje(List<Lenguajes> lenguaje)
        {
            string datos = "";
            for (int i = 0; i < lenguaje.Count; i++)
            {
        
                datos +=lenguaje[i].Lenguaje+"\n";
                }
            return datos;
        }
        public string Proyectos(List<Proyectos> proyecto)
        {
            string datos = "";
            for (int i = 0; i < proyecto.Count; i++)
            {
                datos += proyecto[i].Nombre_Proyecto+ "\n";
                datos += proyecto[i].Descripcion_Proyecto+"\n";
                datos += "\n";
            }
            return datos;
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
    }
}