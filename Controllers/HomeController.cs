using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aws_webapp.Models;
using aws_webapp.Data;

namespace aws_webapp.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController( ApplicationDbContext context)
        {            
            _context = context;
        }


    public IActionResult Index()
    {
        var lista=_context.participantes.ToList();
        return View(lista);
    }
    
    public IActionResult Formulario()
    {
        return View();
    }

    [HttpPost]
        public IActionResult Formulario(Participantes objParticipantes)
        {
            if(ModelState.IsValid)
            {
                _context.Add(objParticipantes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(objParticipantes);
        }

    [HttpPost]
    public IActionResult Borrar(int id)
    {
        var participante = _context.participantes.FirstOrDefault(x => x.id == id);
        _context.Remove(participante);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
