using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9.Models;

namespace TP9.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult GuardarRopa(ropa ropa)
    {
        int ropaAgregadas = BD.agregarRopa(ropa);
        if (ropaAgregadas == 1) ViewBag.MensajeConfirmacion = "Usted agrego una nueva prenda ";
        else ViewBag.MensajeConfirmacion = "Error, intentelo de nuevo!";
        VerDetalleMarca(ropa.IdMarca);
        return View("agregarRopa");
    }

    public IActionResult EliminarPrenda(int IdRopa, int IdMarca)
    {
        int ropaEliminada = BD.EliminarPrenda(IdRopa);
        if (ropaEliminada == 0) ViewBag.MensajeConfirmacion = "Usted elimino un jugador ";
        else ViewBag.MensajeConfirmacion = "Error, intentelo de nuevo!";
        VerDetalleMarca(IdMarca);
        return View("VerDetalleMarca");
    }

    public IActionResult VerDetalleMarca(int IdMarca)
    {
        ViewBag.Marca = BD.ListarMarca(IdMarca);
        ViewBag.ListadoRopa = BD.ListarRopar(IdMarca);
        ViewBag.ListadoMarca = BD.ListarMarcas();
        return View();
    }
    public int AgregarMeGustaAjax(int IdRopa)
    {
        int Cantidad = BD.AgregarMeGusta(IdRopa);
        return Cantidad;
    }

    public ropa VerDetalle(int IdRop)
    {
        ViewBag.ropa = BD.VerInfoPrecio(IdRop);
        return ViewBag.ropa;
    }


    public IActionResult AgregarRopa(ropa IdMarca)
    {
        ViewBag.IdMarca = BD.agregarRopa(IdMarca);
        ViewBag.ListadoMarca = BD.ListarMarcas();
        return View();
    }
    public IActionResult Index()
    {
        ViewBag.ListadoMarca = BD.ListarMarcas();
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
