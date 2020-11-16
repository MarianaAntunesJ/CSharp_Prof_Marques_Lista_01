namespace Lista_01
{
    class Conversor
    {
        static public double MetrosParaCentimetros(double metros) => metros * 100;

        static public double MetrosParaMilimetros(double metros) => metros * 1000;

        static public double FahrenheitParaCelsius(double graus) => (graus - 32.0) * (5.0 / 9.0);

        static public double FahrenheitParaCelsius(int graus) => (graus - 32) * ((double)5 / (double)9);
    }
}
