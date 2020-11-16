using System;

namespace Lista_01
{
    class MenuLeiDeNewton
    {
        static private double ForcaResultante { get; set; }
        static private double MassaDoCorpo { get; set; }
        static private double Aceleracao { get; set; }

        static public void Menu()
        {
            int resp;
            do
            {
                Console.WriteLine("Opções: ");
                Console.WriteLine("1 - Força resultante;");
                Console.WriteLine("2 - Massa do corpo;");
                Console.WriteLine("3 - Aceleração;");
                Console.WriteLine("0 - Sair;");
                Console.Write("opção: ");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        CalculoForcaResultante();
                        break;
                    case 2:
                        CalculoMassadoCorpo();
                        break;
                    case 3:
                        CalculoAceleracao();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (resp != 0);
        }

        static private void CalculoForcaResultante()
        {
            Console.Write("Massa do corpo: ");
            MassaDoCorpo = double.Parse(Console.ReadLine());
            Console.Write("Aceleração: ");
            Aceleracao = double.Parse(Console.ReadLine());
            Console.WriteLine($"Fr = {SegundaLeiDeNewton.CalculoForcaResultante(MassaDoCorpo, Aceleracao):F2}\n");
        }

        static private void CalculoMassadoCorpo()
        {
            Console.Write("Força resultante: ");
            ForcaResultante = double.Parse(Console.ReadLine());
            Console.Write("Aceleração: ");
            Aceleracao = double.Parse(Console.ReadLine());
            Console.WriteLine($"m = {SegundaLeiDeNewton.CalculoMassaDoCorpo(ForcaResultante, Aceleracao):F2}\n");
        }

        static private void CalculoAceleracao()
        {
            Console.Write("Força resultante: ");
            ForcaResultante = double.Parse(Console.ReadLine());
            Console.Write("Massa do corpo: ");
            MassaDoCorpo = double.Parse(Console.ReadLine());
            Console.WriteLine($"a = {SegundaLeiDeNewton.CalculoAceleracao(ForcaResultante, MassaDoCorpo):F2}\n");
        }
    }
}
