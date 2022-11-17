using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace TP9.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private IWebHostEnvironment Environment;

    public HomeController (ILogger<HomeController> logger, IWebHostEnvironment environment)
    {
        _logger = logger;

        Environment = environment;
    }

  /*  public IActionResult GuardarRopa(ropa ropa)
    {
        int ropaAgregadas = BD.agregarRopa(ropa);
        if (ropaAgregadas == 1) ViewBag.MensajeConfirmacion = "Usted agrego una nueva prenda ";
        else ViewBag.MensajeConfirmacion = "Error, intentelo de nuevo!";
        VerDetalleMarca(ropa.IdMarca);
        return View("agregarRopa");
    }*/

    public int EliminarPrenda(int IdRopa, int pIdMarca)
    {
        int ropaEliminada = BD.EliminarPrenda(IdRopa);
        return pIdMarca;
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

    public string VerDesc(string descripcion)
    {
        ViewBag.ropa = BD.VerInfoDesc(descripcion);
        return ViewBag.ropa;
    }
    public IActionResult AgregarRopa()
    {
         ViewBag.ListadoMarca = BD.ListarMarcas();
        return View();

    }

    [HttpPost]
    public IActionResult AgregarRopa(ropa UnaRopa, IFormFile MyFile)
    {
        if(MyFile.Length>0)
        {
            string wwwRootLocal = this.Environment.ContentRootPath + @"\wwwroot\" + MyFile.FileName;
            using (var stream = System.IO.File.Create(wwwRootLocal))
            {
                MyFile.CopyToAsync(stream);
                UnaRopa.Foto = "/" + MyFile.FileName;
            }
        }

        ViewBag.IdMarca = BD.agregarRopa(UnaRopa);
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
