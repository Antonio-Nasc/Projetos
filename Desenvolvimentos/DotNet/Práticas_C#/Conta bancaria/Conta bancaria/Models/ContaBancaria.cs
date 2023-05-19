using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancaria.Models
{
    public class ContaBancaria
    {
        public int NumeroDaConta { get; set; }
        public double SaldoAtual { get; set; }

        public DateTime Data = new DateTime();

        public double Depositar(double deposita)
        {
            SaldoAtual += deposita;
            return SaldoAtual;
        }
        public double Sacar(double saca)
        {
            if(SaldoAtual > saca) 
            {
                SaldoAtual -= saca;
            }
            else
            {
                Console.WriteLine("O valor de saque é maior que seu saldo na conta");
            }
            return SaldoAtual;
        }
        public double VerificarSaldo()
        {
           return SaldoAtual;
        }
       public double Transferir(double transfere)
        {
            if(SaldoAtual > transfere)
            {
                SaldoAtual -= transfere;
            }
            else { Console.WriteLine("Saldo na conta é menor do que deseja transferir."); }
            return SaldoAtual;
        }

    }
}
