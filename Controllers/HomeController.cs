using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Paquete = OrtWorld.DicPaquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.Hotel = OrtWorld.ListaHoteles;
        ViewBag.Aereo = OrtWorld.ListaAereos;
        ViewBag.Excursion =OrtWorld.ListaExcursiones;
        ViewBag.Destino = OrtWorld.ListaDestinos;
        return View();
    }
     
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        if (Destino > 0 && Destino <= 10 && Hotel > 0 && Hotel <= 10 && Excursion > 0 && Excursion <= 10 && Aereo > 0 && Aereo <= 10)
        {
            Paquete paqueteNuevo = new Paquete (OrtWorld.ListaHoteles[Hotel], OrtWorld.ListaAereos[Aereo], OrtWorld.ListaExcursiones[Excursion]);
            OrtWorld.IngresarPaquete(OrtWorld.ListaDestinos[Destino],paqueteNuevo);
            return View("Index");
        }
        else{
            return View("SelectPaquete");   
        }
       
    }

}
