using System.Diagnostics;
using EstudoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoMVC.Controllers;

public class CadastroController : Controller
{
    private readonly ILogger<CadastroController> _logger;

    public CadastroController(ILogger<CadastroController> logger)
    {
        _logger = logger;
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public string Cadastrar([FromForm] UserModel userRequest) //criando formulário
    {
        return $"Nome: {userRequest.Nome}, Email: {userRequest.Email} e Senha: {userRequest.Senha}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}