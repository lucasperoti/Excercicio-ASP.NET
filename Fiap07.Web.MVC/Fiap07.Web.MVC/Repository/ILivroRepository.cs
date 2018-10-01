using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repository
{
    public interface ILivroRepository
    {
        void Cadastrar(Livro livro);
        void Editar(Livro livro);
        void Excluir(int codigo);
        IList<Livro> Listar();
        Livro BuscarPorCodigo(int codigo);

        IList<Livro>
            BuscarPor(Expression<Func<Livro, bool>> filtro);
    }
}