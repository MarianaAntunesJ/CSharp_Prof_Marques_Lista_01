namespace Lista_01
{
    class SegundaLeiDeNewton
    {
        static public double CalculoForcaResultante(double massaDoCorpo, double aceleracao) => massaDoCorpo * aceleracao;
        static public double CalculoMassaDoCorpo(double forcaResultante, double aceleracao) => forcaResultante / aceleracao;
        static public double CalculoAceleracao(double forcaResultante, double massaDoCorpo) => forcaResultante / massaDoCorpo;
    }
}
