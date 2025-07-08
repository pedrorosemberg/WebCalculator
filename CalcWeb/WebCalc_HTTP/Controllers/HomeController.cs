// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using CalculadoraWeb.Models; // Importa sua classe Calculadora

namespace CalculadoraWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Calculadora model)
        {
            if (ModelState.IsValid)
            {
                model.Calcular();
                // ESTA LINHA É CRUCIAL:
                ViewBag.Resultado = model.Resultado; // Passa o resultado para a View usando ViewBag
            }
            // TAMBÉM É CRUCIAL:
            return View("Index", model); // Retorna a mesma View, passando o modelo para preencher os campos e o resultado.
        }
    }
}