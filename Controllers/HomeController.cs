using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto
                {
                    Titulo = "Facturación e Inventario",
                    Descripcion = "Sistema integral que gestiona ventas, control de inventario y emisión de facturas de forma automatizada. Ideal para optimizar procesos, minimizar errores y tener un control preciso del stock en tiempo real",
                    Link = "#",
                    ImgUrl = "https://www.ionos.es/startupguide/fileadmin/StartupGuide/Screenshots_2019/cloud-gestion.png"
                },
                new Proyecto
                {
                    Titulo = "Sistema administrativo financiero",
                    Descripcion = "Plataforma diseñada para gestionar las finanzas, contabilidad y operaciones administrativas de forma eficiente. Permite realizar presupuestos, controlar gastos, administrar cuentas y generar reportes financieros en tiempo real. Ideal para optimizar la gestión económica de empresas y organizaciones",
                    Link = "",
                    ImgUrl = "https://obedalvarado.pw/img/factura_simple.png"
                },
                new Proyecto
                {
                    Titulo = "Sistema de Gestión para Librerías",
                    Descripcion = "Herramienta especializada para la administración de inventario, ventas y catálogo de libros. Automatiza el control de stock, facilita la búsqueda de títulos y autores, y gestiona ventas tanto en tienda física como en línea. Ideal para librerías de cualquier tamaño",
                    Link = "",
                    ImgUrl = "https://www.kanasg.com/wp-content/uploads/2023/10/tipos-de-sistemas-de-facturacion-para-empresas.png"
                },
                new Proyecto
                {
                    Titulo = "Sistema de Gestión de Turnos",
                    Descripcion = "Plataforma que organiza y automatiza la asignación de turnos para optimizar el tiempo de atención. Permite a los clientes reservar turnos en línea, gestionar horarios y reducir tiempos de espera. Ideal para clínicas, bancos y otros servicios con atención al público",
                    Link = "",
                    ImgUrl = "https://facele.co/wp-content/uploads/2019/08/facele-sistema-facturacion-min.jpg"
                },
            };
        }


        public IActionResult Index()
        {
            var persona = new Persona
            {
                nombre = "Tito Fariñas"
            };

            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Persona=persona, Proyectos = proyectos };

            return View("Index", modelo);
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
