using LojinhaDeJogos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojinhaDeJogos.Autenticador
{
    public class Login : Funcionario
    {
        public Login(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override Autenticar
        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double Comissao()
        {
            throw new NotImplementedException();
        }
        
    }
}
