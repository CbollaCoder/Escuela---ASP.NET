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
            return View(new Asignatura{
                Nombre = "Programacion",
                UniqueId = Guid.NewGuid().ToString()
            });
        }
        
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>() {
            new Asignatura {
            Nombre = "Matemáticas",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Educación Física",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Castellano",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Ciencias Naturales",
            UniqueId = Guid.NewGuid ().ToString ()
            },
            new Asignatura {
            Nombre = "Programacion",
            UniqueId = Guid.NewGuid ().ToString ()
            }
            };

            //Uso de ViewBag
            ViewBag.FechaActual = DateTime.Now;

            //Enviar la lista de asignaturas
            //Se coloca el modelo al que referneciamos en primera instancia
            return View("MultiAsignatura",listaAsignaturas );
        }
    }
}
