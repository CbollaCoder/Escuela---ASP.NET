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
            escuela.AñoFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzy Academy";

            //Enviar la escuela a la vista
            return View(escuela);
        }
    }
}
