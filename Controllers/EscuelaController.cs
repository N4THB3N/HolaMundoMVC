using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;

namespace HolaMundoMVC.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Avd Siempre viva";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = "La Monja";
            _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
        public EscuelaController(EscuelaContext context){
            _context = context;
        }
    }
}