using Fiap07.Web.MVC.Persistencia;
using Fiap07.Web.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {
        private LivrariaDbContext _context = new LivrariaDbContext();


        //EDITORA DAO
        private IEditoraRepository _editoraRepository;

        public IEditoraRepository EditoraRepository
        {
            get
            {
                if (_editoraRepository == null)
                {
                    _editoraRepository = new EditoraRepository(_context);
                }
                return _editoraRepository;
            }
        }


        //LIVRO DAO
        private ILivroRepository _livroRepository;

        public ILivroRepository LivroRepository
        {
            get
            {
                if (_livroRepository == null)
                {
                    _livroRepository = new LivroRepository(_context);
                }
                return _livroRepository;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}