﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_Encapsulamento
{
    public class Aluno
    {
        private int matricula;
        public int Matricula
        {
            get { return matricula; }
            set
            {
                if (value >= 0)
                {
                    matricula = value;
                }
                else
                {
                    Console.WriteLine("Valor da matrícula não pode ser menor que zero.");
                }

            }
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }

    }
}
