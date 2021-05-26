using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRACTICA03.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace PRACTICA03.Controllers
{
    public class ubicacionescontrolller  : Controller
    {


  private readonly aplicacioncontext _context;
        public ubicacionescontrolller(aplicacioncontext context) {
            _context = context;
        }


        public IActionResult arte() {
            var artes = _context.artes.Include(x => x.categoria).OrderBy(r => r.Nombre).ToList();
            return View(artes);
        }

        public IActionResult muebles() {
            var mueble= _context.mueble.Include(x => x.categoria).OrderBy(r => r.Nombre).ToList();
            return View(mueble);
        }

        public IActionResult ropa() {
            var ropas = _context.ropas.Include(x => x.categoria).OrderBy(r => r.Nombre).ToList();
            return View(ropas);
        }

        public IActionResult tecnologia() {
            var tecnologias = _context.tecnologias.Include(x => x.categoria).OrderBy(r => r.Nombre).ToList();
            return View(tecnologias);
        }



        public IActionResult  Nuevoproducto() {
            ViewBag.arte = _context.artes.ToList().Select(p => new SelectListItem(p.Nombre, p.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevoProducto(usuario r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevoProductoConfirmacion() {
            return View();
        }
        
    }
}