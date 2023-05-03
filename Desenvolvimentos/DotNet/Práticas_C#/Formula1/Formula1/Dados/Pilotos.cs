using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Dados
{
    public class Pilotos
    {
       

        public Pilotos(string nome, string equipe)
        {
            this.Nome = nome;
            this.Equipe = equipe;
        }

        public string Nome { get; set; }
        public string Equipe { get; set; }    
    }
}
