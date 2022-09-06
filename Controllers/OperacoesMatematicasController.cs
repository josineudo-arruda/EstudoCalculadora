using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EstudoMVC.Models;

namespace EstudoMVC.Controllers;

public class OperacoesMatematicasController : Controller {

    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult Dividir()
    {
        return View();
    }

    public IActionResult OperacaoSomar([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Operacao = "Soma";
        ViewBag.Numero1 = num1;
        ViewBag.Numero2 = num2;
        ViewBag.Resultado = num1 + num2;
        return View("ResultadoOperacoes");
    }

    public IActionResult OperacaoSubtrair([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Operacao = "Subtração";
        ViewBag.Numero1 = num1;
        ViewBag.Numero2 = num2;
        ViewBag.Resultado = num1 - num2;
        return View("ResultadoOperacoes");
    }

    public IActionResult OperacaoMultiplicar([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Operacao = "Multiplicação";
        ViewBag.Numero1 = num1;
        ViewBag.Numero2 = num2;
        ViewBag.Resultado = num1 * num2;
        return View("ResultadoOperacoes");
    }

    public IActionResult OperacaoDividir([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Operacao = "Divisão";
        ViewBag.Numero1 = num1;
        ViewBag.Numero2 = num2;
        ViewBag.Resultado = num1 / num2;
        return View("ResultadoOperacoes");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}