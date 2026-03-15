using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista03.Models
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int Ano { get; set; }

        public string Genero { get; set; }

        public bool Disponivel { get; set; }
    }
}