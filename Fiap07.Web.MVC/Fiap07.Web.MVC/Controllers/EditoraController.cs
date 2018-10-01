using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class EditoraController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();


        //Retornar a view de cadastrar
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Editora editora)
        {
            _unit.EditoraRepository.Cadastrar(editora);
            _unit.Salvar();
            TempData["msg"] = "Editora cadastrada com sucesso.";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}