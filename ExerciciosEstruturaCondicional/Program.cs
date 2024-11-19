using System.Globalization;

namespace ExerciciosEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            //Exercicio8();
        }

        static void Exercicio1()
        {
            int x;

            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("\nNEGATIVO");
            }
            else
            {
                Console.WriteLine("\nNAO NEGATIVO");
            }
        }

        static void Exercicio2()
        {
            int x;

            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("\nPAR");
            }
            else
            {
                Console.WriteLine("\nIMPAR");
            }
        }

        static void Exercicio3()
        {
            int a, b;

            Console.Write("Digite dois numeros inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("\nSao Multiplos");
            }
            else
            {
                Console.WriteLine("\nNao sao Multiplos");
            }
        }

        static void Exercicio4()
        {
            double horaInicio, horaFim, duracao;

            Console.Write("Digite a hora inicial e a hora final do jogo: ");
            string[] horario = Console.ReadLine().Split(' ');
            horaInicio = int.Parse(horario[0]);
            horaFim = int.Parse(horario[1]);

            if (horaInicio < horaFim)
            {
                duracao = horaFim - horaInicio;
            }
            else
            {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine($"\nO JOGO DUROU {duracao} HORA(S)");
        }

        static void Exercicio5()
        {
            int codProduto, quantProduto;
            double valorTotal = 0;

            Console.Write("Digite o codigo e a quantidade do produto consumido: ");
            string[] valores = Console.ReadLine().Split(' ');
            codProduto = int.Parse(valores[0]);
            quantProduto = int.Parse(valores[1]);

            switch (codProduto)
            {
                case 1:
                    valorTotal = quantProduto * 4.00;
                    break;

                case 2:
                    valorTotal = quantProduto * 4.50;
                    break;

                case 3:
                    valorTotal = quantProduto * 5.00;
                    break;

                case 4:
                    valorTotal = quantProduto * 2.00;
                    break;

                case 5:
                    valorTotal = quantProduto * 2.00;
                    break;
            }

            Console.WriteLine($"\nTotal: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void Exercicio6()
        {
            double x;

            Console.Write("Digite um numero qualquer: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x < 0 || x > 100)
            {
                Console.WriteLine("Fora do intervalo");
            }

            else if (x <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }

            else if (x <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }

            else if (x <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }

            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }

        static void Exercicio7()
        {
            double x, y;

            Console.Write("Digite as coordenadas do plano cartesiano: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        static void Exercicio8()
        {
            double renda, impostoDeRenda = 0.0;

            Console.Write("Digite o salario: ");
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            else if (renda <= 3000.00)
            {
                impostoDeRenda = (renda - 2000.00) * 0.08;
            }

            else if (renda <= 4500.00)
            {
                impostoDeRenda = (renda - 3000.00) * 0.18 + 1000.00 * 0.08;
            }

            else
            {
                impostoDeRenda = (renda - 4500.00) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            Console.WriteLine($"Imposto de Renda = R$ {impostoDeRenda.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
