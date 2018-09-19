using Fiap05.web.mvc.Models;
using Fiap05.web.mvc.Perssistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.web.mvc.Controllers
{
    public class EspecialidadeController : Controller
    {
        private HospitalContext _context = new HospitalContext();
        // GET: Especialidade
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
            {
                return View();
            }
        [HttpPost]
        public ActionResult Cadastrar(Especialidade e)
        {
            _context.Especialidades.Add(e);
            _context.SaveChanges();
            TempData["msg"] = "Especialidade cadastrada!";
            return RedirectToAction("Cadastrar");
        }


        public ActionResult Editar(int id)
        {
            var especialidade = _context.Especialidades.Find(id);
            return View(especialidade);
        }

        [HttpPost]
        public ActionResult Editar (Especialidade e)
        {
            _context.Entry(e).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Especialidade atualizada";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            var e = _context.Especialidades.Find(id);
            _context.Especialidades.Remove(e);
            _context.SaveChanges();
            TempData["msg"] = "Removido!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Especialidades.ToList());
        }
    }
}