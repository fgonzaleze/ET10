using Entities;
using ET10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace ET10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            SqlConnection miConexion = new SqlConnection();
            try
            {
              
                miConexion.ConnectionString = "server=jgonzaleze.database.windows.net;database=JaviDB;uid=prueba;pwd=fernandoG321;trustServerCertificate=true";
                miConexion.Open();
                ViewBag.ConnectionState = $"Conectado: {miConexion.State}";
            }
            catch (Exception ex)
            {
                ViewBag.ConnectionState = $"Error al conectar: {ex.Message}";
            }

            return View();

        }

        public IActionResult ListaPersonas() 
        {
            try
            {
            List<clsPersona> listadoPersonas = DAL.clsListadoPersonas.getListadoPersonas();
            return View(listadoPersonas);
            } catch (Exception ex)
            {
                return View("Error");
            }
        
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
}