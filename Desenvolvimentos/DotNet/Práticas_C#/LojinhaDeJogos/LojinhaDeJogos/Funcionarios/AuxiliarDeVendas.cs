using LojinhaDeJogos.Autenticador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojinhaDeJogos.Funcionarios
{
    public class AuxiliarDeVendas : Login
    {
        public AuxiliarDeVendas(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double Comissao()
        {
            return Salario * 0.07;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.20;
        }
    }
}
