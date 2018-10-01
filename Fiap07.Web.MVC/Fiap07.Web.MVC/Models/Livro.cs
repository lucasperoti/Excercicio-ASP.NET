﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public int Paginas { get; set; }
        public String Titulo { get; set; }

        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
    }
}