using Microsoft.AspNetCore.Mvc;
using MiPrimerProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Controllers
{
    public class EscuelaController : Controller
    {
        
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzy Academy";
            escuela.Ciudad = "Bogotá";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Av. Siempre Viva, #1950";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //Uso de ViewBag
            ViewBag.FechaActual = DateTime.Now;

            //Enviar la escuela a la vista
            return View(escuela);
        }
    }
}
