using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Book
{
    public class Livro
    {
        public Livro(string titulo, string isbn)
        {
            this.Titulo = titulo;
            this.Isbn = isbn;
        }
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Isbn { get; private set; }
        public int AnoDePublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

    }
}
