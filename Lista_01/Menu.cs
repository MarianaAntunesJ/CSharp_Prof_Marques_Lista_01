using System;

namespace Lista_01
{
    class Menu
    {
        static public void MenuOpcoes()
        {
            int resp;
            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine(" 1 - Conversor metros;");
                Console.WriteLine(" 2 - Conversor Fahrenheit;");
                Console.WriteLine(" 3 - Cálculo IMC;");
                Console.WriteLine(" 4 - Media pondeirada;");
                Console.WriteLine(" 5 - Segunda Lei de Newton;");
                Console.WriteLine(" 6 - Salário c/ aumento 25%;");
                Console.WriteLine(" 7 - Conversor dólar;");
                Console.WriteLine(" 8 - Soma;");
                Console.WriteLine(" 9 - Um dígito por linha;");
                Console.WriteLine("10 - Investimento de Marquesito;");
                Console.WriteLine("11 - Número ao quadrado e ao cubo;");
                Console.WriteLine("12 - Peso ideal;");
                Console.WriteLine(" 0 - Sair;\n");
                Console.Write("opção: ");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Perguntas.Pergunta01();
                        break;
                    case 2:
                        Perguntas.Pergunta02();
                        break;
                    case 3:
                        Perguntas.Pergunta03();
                        break;
                    case 4:
                        Perguntas.Pergunta04();
                        break;
                    case 5:
                        Perguntas.Pergunta05();
                        break;
                    case 6:
                        Perguntas.Pergunta06();
                        break;
                    case 7:
                        Perguntas.Pergunta07();
                        break;
                    case 8:
                        Perguntas.Pergunta08();
                        break;
                    case 9:
                        Perguntas.Pergunta09();
                        break;
                    case 10:
                        Perguntas.Pergunta10();
                        break;
                    case 11:
                        Perguntas.Pergunta11();
                        break;
                    case 12:
                        Perguntas.Pergunta12();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (resp != 0);
        }
    }
}
