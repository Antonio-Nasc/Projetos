using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojinhaDeJogos.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
        }
    
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; set; }
        public double Salario { get; protected set; }

        public abstract double Comissao();

        public abstract void AumentarSalario();
        
    }
}
