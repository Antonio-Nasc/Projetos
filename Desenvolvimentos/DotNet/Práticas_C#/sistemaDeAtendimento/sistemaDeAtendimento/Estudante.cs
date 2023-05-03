using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaDeAtendimento
{
    public class Estudante
    {
        public Estudante(string nome, string curso, string periodo)
        {
            this.Nome = nome;
            this.Curso = curso;
            this.Periodo = periodo;
        }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Periodo { get; set; }

    }
}
