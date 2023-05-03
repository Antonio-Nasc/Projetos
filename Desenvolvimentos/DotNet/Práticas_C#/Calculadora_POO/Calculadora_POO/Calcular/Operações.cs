using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO.Calcular
{
    public class Operações
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set;}

        public double Somar()
        {
            return this.Valor1 + this.Valor2;
        }
        public double Subtrair()
        {
            return this.Valor1 - this.Valor2;
        }
        public double Multiplicar()
        {
            return this.Valor1 * this.Valor2;
        }
        public double Dividir()
        {
            return this.Valor1 / this.Valor2;
        }
    }
}
