using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using entity.Models;
using entity.Contexto;

namespace entity.Controllers;


public class HomeController : Controller
{
    private readonly DbContexto context;

    public HomeController(DbContexto context)
    {
        this.context = context;
    }

    public IActionResult Index(int id)
    {
        var clientes = context.Clientes.Where(c => c.Nome.Contains("Dani")).ToList();
        var fornecedores = context.Fornecedores.ToList();

        ViewBag.clientes = clientes;
        ViewBag.fornecedores = fornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
