using entity.Contexto;
using entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace entity.Controllers;

public class ClientesController : Controller
{

    private readonly DbContexto context;
    public ClientesController(DbContexto context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        ViewBag.clientes = context.Clientes.ToList();
        return View();
    }

    public IActionResult Novo()
    {
        return View();
    }

    public IActionResult Cadastrar([FromForm] Cliente cliente)
    {
        if(string.IsNullOrEmpty(cliente.Nome))
        {
            ViewBag.erro = "O nome não pode ser vazio";
            return View();
        }

        context.Clientes.Add(cliente);
        context.SaveChanges();

        return Redirect("/clientes");
    }

    [Route("/clientes/{id}/editar")]
    public IActionResult Editar([FromRoute] int id)
    {
        ViewBag.cliente = context.Clientes.Where(c => c.Id == id).FirstOrDefault();
        return View();
    }

    [Route("/clientes/{id}/atualizar")]
    public IActionResult Atualizar([FromRoute] int id, [FromForm] Cliente cliente)
    {
        var clienteBb = context.Clientes.Where(c => c.Id == id).FirstOrDefault();
        if(clienteBb == null)
        {
            return Redirect("/clientes");
        }

        clienteBb.Nome = cliente.Nome;
        clienteBb.Email = cliente.Email;
        context.Update(clienteBb);
        context.SaveChanges();

        return Redirect("/clientes");
    }

    [Route("/clientes/{id}/deletar")]
    public IActionResult Apagar([FromRoute] int id)
    {
        var clienteBb = context.Clientes.Where(c => c.Id == id).FirstOrDefault();
        if(clienteBb == null)
        {
            return Redirect("/clientes");
        }

        context.Clientes.Remove(clienteBb);
        context.SaveChanges();

        return Redirect("/clientes");
    }
}
