using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica3_Unidad_2.Models;
namespace Practica3_Unidad_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var personas = new List<Persona>
            {
                new Persona{Nombre= "Ronald",     Apellido= "Peña",       Telefono="8094289055",     Id= "130252552-2"},
                new Persona{ Nombre="Esther",    Apellido= "Arismedi",   Telefono="8092454814",      Id="015-2536548-1"},
                new Persona{ Nombre="Ruth",      Apellido= "Granado",    Telefono="8092452225",      Id="018-212548-1"},
                new Persona{ Nombre="Santiago",  Apellido= "Gutierrez",  Telefono="8091249714",      Id="018-2534588-1"},

            };
            return View(personas);

            






        }
    }
}