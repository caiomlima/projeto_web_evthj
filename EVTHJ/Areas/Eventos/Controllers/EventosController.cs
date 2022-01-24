using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVTHJ.Areas.Eventos.Controllers {
    [Area("Eventos")]
    public class EventosController : Controller {

        public IActionResult Index() {
            return View();
        }


        // Create
        [HttpGet, ActionName("Novo-evento")]
        public IActionResult Create() {
            return View();
        }


        // Details (Read)
        [HttpGet, ActionName("Detalhes-do-evento")]
        public IActionResult Details() {
            return View();
        }


        // Update
        [HttpGet, ActionName("Editar-evento")]
        public IActionResult Edit() {
            return View();
        }


        // Delete
        [HttpGet, ActionName("Apagar-evento")]
        public IActionResult Delete() {
            return View();
        }

    }
}
