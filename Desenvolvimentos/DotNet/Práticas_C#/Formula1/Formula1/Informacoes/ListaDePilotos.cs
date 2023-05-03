using Formula1.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Informacoes
{
    public class ListaDePilotos
    {
        private Pilotos[] _itens = null;
        private int proximaPosicao = 0;

        public ListaDePilotos(int tamanhoInicial=4)
        {
            _itens = new Pilotos[tamanhoInicial];
        }

        public void Adicionar(Pilotos item)
        {
            Console.WriteLine($"Adicionado item na posição {proximaPosicao}");
            VerificarCapacidade(proximaPosicao + 1);
            _itens[proximaPosicao] = item;
            proximaPosicao++;
            
        }
        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length > tamanhoNecessario) 
            {
                return;
            }
            Pilotos[] novoArray = new Pilotos[tamanhoNecessario];
            for(int i = 0; i< _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;

        }
        public void Remover(Pilotos item)
        {
            int indiceItem = -1;
            for(int i = 0; i< _itens.Length; i++)
            {
                Pilotos contaAtual = _itens[i];
                if(contaAtual == item)
                {
                    indiceItem = i; break;
                }
            }
            for(int i = indiceItem; i< proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            proximaPosicao--;
            _itens[proximaPosicao] = null;
        }
        public void ExibirResultado()
        {
            for(int i = 0; i< _itens.Length; i++)
            {
                if(_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($"Indice {i} - Piloto: {conta.Nome}. Equipe: {conta.Equipe}");
                }
            }
        }

    }
}
