using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroPOO.Models;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string AnoDeFabricacao { get; set; }
    public int NumeroDePortas { get; set; }
    public string Cor { get; set; }

    public string Acelerar()
    {
        return "Carro em movimento";
    }
    public string frear()
    {
        return "Carro freando";
    }
    public string MudarMarcha()
    {
        return "Mudando de marcha";
    }
    public string LigarMotor()
    {
        return "Ligando motor";
    }
    public string DesligarMotor()
    {
        return "Desligando motor";
    }
}
