using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repository
{
    public class EditoraRepository : IEditoraRepository
    {
        private LivrariaDbContext _context;

        public EditoraRepository(LivrariaDbContext context)
        {
            _context = context;
        }

        public IList<Editora> BuscarPor(Expression<Func<Editora ,bool>> filtro)
        {
            return _context.Editoras.Where(filtro).ToList();
        }

        public Editora BuscarPorCodigo(int codigo)
        {
            return _context.Editoras.Find(codigo);
        }

        public void Cadastrar(Editora editora)
        {
            _context.Editoras.Add(editora);
        }

        public void Editar(Editora editora)
        {
            _context.Entry(editora).State = EntityState.Modified;
        }

        public void Excluir(int codigo)
        {
            var est = BuscarPorCodigo(codigo);
            _context.Editoras.Remove(est);
        }

        public IList<Editora> Listar()
        {
            return _context.Editoras.ToList();
        }
    }
}