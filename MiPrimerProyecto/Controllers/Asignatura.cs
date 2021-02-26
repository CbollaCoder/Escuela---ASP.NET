using Microsoft.AspNetCore.Mvc;
using MiPrimerProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Controllers
{
    public class AsignaturaController : Controller
    {
        
        public IActionResult Index()
        {
            var asignatura = new Asignatura { 
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };

            //Uso de ViewBag
            ViewBag.FechaActual = DateTime.Now;

            //Enviar la escuela a la vista
            return View(asignatura);
        }
    }
}
