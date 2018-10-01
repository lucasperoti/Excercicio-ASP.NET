
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap07.Web.MVC.UnitsOfWork;
using System.Web.Mvc;
using Fiap07.Web.MVC.Models;

namespace Fiap07.Web.MVC.Controllers
{
    public class LivroController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();


        private void CarregarCombo()
        {
            var eds = _unit.EditoraRepository.Listar();
            ViewBag.editoras = new SelectList(eds, "EditoraId", "Nome");
        }

        //Retornar a view de cadastro
        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarCombo();
            return View();
        }


        [HttpPost]
        public ActionResult Cadastrar(Livro livro)
        {
            _unit.LivroRepository.Cadastrar(livro);
            _unit.Salvar();
            TempData["msg"] = "Livro cadastrado.";
            return RedirectToAction("Cadastrar");
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }
}