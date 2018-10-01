using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;

namespace Fiap07.Web.MVC.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private LivrariaDbContext _context;

        public LivroRepository(LivrariaDbContext context)
        {
            _context = context;
        }

        public IList<Livro> BuscarPor(Expression<Func<Livro, bool>> filtro)
        {
            return _context.Livros.Where(filtro).ToList();
        }

        public Livro BuscarPorCodigo(int codigo)
        {
            return _context.Livros.Find(codigo);
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
        }

        public void Editar(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
        }

        public void Excluir(int codigo)
        {
            var est = BuscarPorCodigo(codigo);
            _context.Livros.Remove(est);
        }

        public IList<Livro> Listar()
        {
            return _context.Livros.Include("Editora").ToList();
        }
    }
}