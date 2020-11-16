namespace Lista_01
{
    class Notas
    {
        public double Nota { get; set; }

        public double Peso { get; set; }

        public double NotaPondeirada { get { return Nota * (Peso / 10); } }
    }
}
