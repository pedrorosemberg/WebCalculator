using Microsoft.AspNetCore.Mvc;
using CalculadoraWeb.Models; // Importa sua classe Calculadora

namespace CalculadoraWeb.Controllers
{
    public class HomeController : Controller
    {
        // Esta action exibe o formulário da calculadora
        public IActionResult Index()
        {
            return View();
        }

        // Esta action processa os dados do formulário quando enviados
        [HttpPost] // Indica que esta action responde a requisições POST
        public IActionResult Calcular(Calculadora model)
        {
            if (ModelState.IsValid) // Verifica se os dados enviados são válidos
            {
                model.Calcular();
                ViewBag.Resultado = model.Resultado; // Passa o resultado para a View
            }
            return View("Index", model); // Retorna a mesma View com o resultado
        }
    }
}