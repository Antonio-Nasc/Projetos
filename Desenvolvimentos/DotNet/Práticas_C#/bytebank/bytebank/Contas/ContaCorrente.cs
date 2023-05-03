using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {   
        public static int TotalDeContasCriadas { get; private set; }
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    numero_agencia = value;
                }
            }
        }
        //Auto implementaçao
        //private string conta;
        public string Conta { get; set; }
        
        public Cliente Titular { get; set; }
        private double saldo = 100;
        public double Saldo { get; set; }   


        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void Informar()
        {
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Número da agencia: " + numero_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }


        //Criação de construtor
        //O construtor fará com que as informações criadas aqui, ao ser jogada no programa, deverão ser obrigatoriamente utilizada.

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            Numero_agencia= numero_agencia;
            Conta = numero_conta;
            TotalDeContasCriadas++;

        }

        //Ao criar um outro construtor fácil, fica de escolha passar logo as informações
    }



}
