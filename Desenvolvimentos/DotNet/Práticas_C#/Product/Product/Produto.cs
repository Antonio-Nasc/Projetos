using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Produto
    {
        public string Name { get; set; }
        public string Descripton { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }

        public void AddToStock(int quantidade)
        {
            int soma = quantidade + this.InStock;
            Console.WriteLine(soma);
        }

        public double CalculateDiscount(double desconto)
        {
            return this.Price * (100 - desconto) / 100;
        }
    }
}
