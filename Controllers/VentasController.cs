using Microsoft.AspNetCore.Mvc;
using Formulario_lab_S2.Models;

namespace Formulario_lab_S2.Controllers
{
    public class VentasController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        


        [HttpPost]
        public IActionResult Calcular(Ventas objventas)
        {
            double resultado=0;
            resultado = (objventas.Precio * objventas.Cantidad)*1.18;
            ViewData["Message"] = "El precio total teniendo en cuenta el IGV es: "+ resultado; 
           return View("Index");
        }
    }
}