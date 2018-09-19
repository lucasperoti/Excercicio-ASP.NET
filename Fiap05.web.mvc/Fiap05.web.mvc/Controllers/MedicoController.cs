using Fiap05.web.mvc.Models;
using Fiap05.web.mvc.Perssistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.web.mvc.Controllers
{
    public class MedicoController : Controller
    {
        private HospitalContext _context = new HospitalContext();

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Medicos.Include("Especialidade").ToList();
            return View(lista);
        }



        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _context.Especialidades.ToList();
            ViewBag.naoLembro = new SelectList(lista, "EspecialidadeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Medico m)
        {
            _context.Medicos.Add(m);
            _context.SaveChanges();
            TempData["msg"] = "Medico cadastrado!";
            return RedirectToAction("Cadastrar");
        }

    }
}