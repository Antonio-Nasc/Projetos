using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    public class Cidadao
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public DateTime DataNascimento { get; set; }
        public float Altura { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine( "Altura: " + Altura);
            Console.WriteLine("Data de nascimento: " + DataNascimento);
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - DataNascimento.Year;
        }

    }
}
