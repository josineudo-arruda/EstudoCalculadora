using System.Diagnostics; // para Activity no final dessa classe
using EstudoMVC.Models; // para o erro de null no final
using Microsoft.AspNetCore.Mvc; // para o Controller

namespace EstudoMVC.Controllers; // nomeando

public class CalculadoraController : Controller
{
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    public IActionResult Calculadora() // apresentando a view
    {
        return View();
    }

    public IActionResult Calcular([FromForm] double num1, [FromForm] double num2, [FromForm] string operacao)
    {
        //operacao.ToLower();
        if(operacao == "soma")
        {
            ViewBag.Operacao = operacao;
            ViewBag.Numero1 = num1;
            ViewBag.Numero2 = num2;
            ViewBag.Resultado = num1 + num2;
            return View("ResultadoCalculadora");
        }
        if(operacao == "subtrair")
        {
            ViewBag.Operacao = operacao;
            ViewBag.Numero1 = num1;
            ViewBag.Numero2 = num2;
            ViewBag.Resultado = num1 - num2;
            return View("ResultadoCalculadora");
        }
        if(operacao == "multiplicar")
        {
            ViewBag.Operacao = operacao;
            ViewBag.Numero1 = num1;
            ViewBag.Numero2 = num2;
            ViewBag.Resultado = num1 * num2;
            return View("ResultadoCalculadora");
        }
        if(operacao == "dividir")
        {
            ViewBag.Operacao = operacao;
            ViewBag.Numero1 = num1;
            ViewBag.Numero2 = num2;
            ViewBag.Resultado = num1 / num2;
            return View("ResultadoCalculadora");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}