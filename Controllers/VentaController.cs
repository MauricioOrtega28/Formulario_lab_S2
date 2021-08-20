using Microsoft.AspNetCore.Mvc;
using Formulario_lab_S2.Models;

namespace Formulario_lab_S2.Controllers
{
    public class VentaController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
           ViewData["Message"] = "Se registró la venta"; 
           return View("Index");
        }


        [HttpGet]
        public IActionResult Calcular(Ventas objventas)
        {
            double resultado=0;
            resultado = (objventas.Precio * objventas.Cantidad)*1.18;
            ViewData["Message"] = "El precio total inluyendo el IGV es: "+ resultado; 
           return View("Index");
        }
    }
}