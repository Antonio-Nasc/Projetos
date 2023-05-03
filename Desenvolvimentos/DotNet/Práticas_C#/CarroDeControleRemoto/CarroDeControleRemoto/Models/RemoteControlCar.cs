using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroDeControleRemoto.Models
{
    public class RemoteControlCar
    {
        public RemoteControlCar(int bateria, int velocidade)
        {
            Bateria = bateria;
            Velocidade = velocidade;
        }
        public int Bateria = 5;
        public int Velocidade = 2;
    }
}
