using System;

namespace Lista_01
{
    class Pessoa
    {
        public double Altura { get; set; }

        public double Peso { get; set; }

        public double IMC { get { return Peso / Math.Pow(Altura, 2.0); } }
    }
}
