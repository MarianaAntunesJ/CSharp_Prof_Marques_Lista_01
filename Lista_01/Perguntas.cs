using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista_01
{
    class Perguntas
    {
        static public void Pergunta01()
        {
            Console.Write("Metro(s): ");
            double metros = double.Parse(Console.ReadLine());
            Console.WriteLine($"{metros}m em: ");
            Console.WriteLine($"Centímetros: {Conversor.MetrosParaCentimetros(metros)}cm");
            Console.WriteLine($"Milimetros: {Conversor.MetrosParaMilimetros(metros)}mm");
        }

        static public void Pergunta02()
        {
            Console.WriteLine("\nGraus Fahrenheit: ");
            Console.Write("Double: ");
            double grausD = float.Parse(Console.ReadLine());
            Console.Write("Int: ");
            int grausI = int.Parse(Console.ReadLine());
            Console.WriteLine($"{grausD:F1}°F em: ");
            Console.WriteLine($"Graus Celsius: {Conversor.FahrenheitParaCelsius(grausD):F2}°C");
            Console.WriteLine($"{grausI}°F em: ");
            Console.WriteLine($"Graus Celsius: {Conversor.FahrenheitParaCelsius(grausI):F2}°C");
        }

        static public void Pergunta03()
        {
            Pessoa pessoa = new Pessoa();
            Console.Write("\nAltura: ");
            pessoa.Altura = double.Parse(Console.ReadLine());
            Console.Write("Peso: ");
            pessoa.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine($"IMC = {pessoa.IMC:F2}");
        }

        static public void Pergunta04()
        {
            List<Notas> notas = new List<Notas>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nota {i+1}:");
                Notas nota = new Notas();
                Console.Write("Nota: ");
                nota.Nota = double.Parse(Console.ReadLine());
                Console.Write("Peso: ");
                nota.Peso = double.Parse(Console.ReadLine());
                notas.Add(nota);
            }
            Console.WriteLine($"Media Pondeirada = {notas.Sum(_ => _.NotaPondeirada):F2}");
        }

        static public void Pergunta05()
        {
            Console.WriteLine("Fórmula: Fr = m.a");
            MenuLeiDeNewton.Menu();
        }

        static public void Pergunta06()
        {
            Console.Write("Digite o valor do salário atual: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Novo salário com aumento de 25% = R${salario + (salario * 0.25):F2}");
        }

        static public void Pergunta07()
        {
            Console.Write("Valor em real: ");
            double real = double.Parse(Console.ReadLine());
            Console.Write("Cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor em dólar(es) = R${real / cotacao:F2}");
        }

        static public void Pergunta08()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total = {((numero * 3) + 1) + ((numero * 2) - 1) }");
        }

        static public void Pergunta09()
        {
            Console.Write("Digite um número inteiro (minímo 4 digitos):");
            string numero = Console.ReadLine();
            for (int i = 0; i < numero.Length; i++)
                Console.WriteLine(numero.Substring(i, 1));
        }

        static public void Pergunta10()
        {
            Console.Write("Valor do investimento: ");
            double investimento = double.Parse(Console.ReadLine());
            Console.Write("Número de dias: ");
            int dias = int.Parse(Console.ReadLine());
            for (int i = 0; i < dias; i++)
            {
                Console.WriteLine($"\nDia {i + 1}:");
                Console.WriteLine("1 - Ganho");
                Console.WriteLine("2 - Perca");
                Console.WriteLine("0 - Sair");
                Console.Write("opção: ");
                int resp = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem (sem o símbolo %): ");
                double porcentagem = double.Parse(Console.ReadLine());
                if (resp == 1)
                    investimento += (investimento * (porcentagem / 100));
                else if (resp == 2)
                    investimento -= (investimento * (porcentagem / 100));
                else if (resp == 0)
                    break;
                Console.WriteLine($"Total após {dias} dia(s) = R${investimento:F2}");
            }
        }

        static public void Pergunta11()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ao quadrado = {Math.Pow(numero, 2)}\nAo cubo = {Math.Pow(numero, 3)}");
        }

        static public void Pergunta12()
        {
            Console.WriteLine("Genêro: ");
            Console.WriteLine("1 - Mulher;");
            Console.WriteLine("2 - Homem;");
            Console.Write("Opção: ");
            int resp = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());
            if (resp == 1)
                Console.WriteLine($"Peso ideal = {((62.1 * altura) - 44.7):F2}");
            else if (resp == 2)
                Console.WriteLine($"Peso ideal = {((72.7 * altura) - 58):F2}");
        }
    }
}
