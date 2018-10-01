using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repository
{
    public interface IEditoraRepository
    {
        void Cadastrar(Editora editora);
        void Editar(Editora editora);
        void Excluir(int codigo);

        IList<Editora> Listar();

        Editora BuscarPorCodigo(int codigo);

        IList<Editora> BuscarPor(Expression<Func<Editora, bool>> filtro);
    }
}