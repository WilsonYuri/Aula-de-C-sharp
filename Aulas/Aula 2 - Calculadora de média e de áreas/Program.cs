using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetoEmAula2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;

            Console.WriteLine("Qual exercicio você quer testar? Exercício 01 ou 02?");
            ex = int.Parse(Console.ReadLine() );
            Console.WriteLine();

            if (ex.Equals(1))
            {
                double ressoma, num1, num2, num3, num4, num5;
                double resultado;

                // fiz em double para ele mostrar as casas decimais

                Console.WriteLine("Digite a primeira nota ");

                num1 = double.Parse(Console.ReadLine());

                // guarda os valores da primeira nota

                Console.WriteLine("Digite a segunda nota ");

                num2 = double.Parse(Console.ReadLine());

                // guarda os valores da segunda nota

                Console.WriteLine("Digite terceira nota ");

                num3 = double.Parse(Console.ReadLine());

                // guarda os valores da terceira nota

                Console.WriteLine("Digite a quarta nota ");

                num4 = double.Parse(Console.ReadLine());

                // guarda os valores da quarta nota

                Console.WriteLine("Digite terceira nota ");

                num5 = double.Parse(Console.ReadLine());

                // guarda os valores da quinta nota

                ressoma = (num1 + num2 + num3 + num4 + num5);
                resultado = (ressoma / 5.0);

                // faz a soma e a divisão para saber a média das notas

                Console.Write("O resultado é {0}", resultado);

                Console.ReadKey();
            }

            else if (ex.Equals(2)){

                string op;

                Console.WriteLine("Qual vai ser calculado a àrea? Retângulo, Triângulo, Círculo, Delta, Juros");
                op = (Console.ReadLine());

                if (op.Equals("Retangulo"))
                {
                    double alt, bas, res;

                    Console.WriteLine("Digite a altura");
                    alt = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a base");
                    bas = double.Parse(Console.ReadLine());

                    res = (alt * bas);
                    Console.WriteLine("A área é {0}", res);

                    Console.ReadKey();
                }

                else if (op.Equals("Triangulo"))
                {
                    double alt, bas, res;

                    Console.WriteLine("Digite a altura");
                    alt = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a base");
                    bas = double.Parse(Console.ReadLine());

                    res = (alt * bas) / 2;
                    Console.WriteLine("A área é {0}", res);

                    Console.ReadKey();


                }

                else if (op.Equals("Circulo"))
                {
                    double rai, dia, res;

                    Console.WriteLine("Digite o raio");
                    rai = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a diametro");
                    dia = double.Parse(Console.ReadLine());

                    res = (3.14 * dia);
                    Console.WriteLine("A área é {0}", res);

                    Console.ReadKey();
                }

                else if (op.Equals("Delta"))
                {
                    double a, b, c;
                    double delta_p1, delta_p2, delta;
                    double a1, a2;
                    double resultado_a1, resultado_a2;

                    Console.WriteLine("Digite o valor de a");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor de b");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor de c");
                    c = double.Parse(Console.ReadLine());

                    delta_p1 = Math.Sqrt(b * b);
                    delta_p2 = Math.Sqrt(4 * a * c);

                    delta = (delta_p1 - delta_p2);

                    a1 = (-b + (delta)) / (2 * a);
                    a2 = (-b - (delta)) / (2 * a);

                    resultado_a1 = a1;
                    resultado_a2 = a2;

                    Console.WriteLine("O resultado 1 é {0} ", resultado_a1);
                    Console.WriteLine("O resultado 2 é {0} ", resultado_a2);

                    Console.ReadKey();

                }

                else if (op.Equals("Juros"))
                {
                    double val, tax;
                    int mes;
                    double jur;

                    Console.WriteLine("Quanto é o salário?");
                    val = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto é a taxa?");
                    tax = double.Parse(Console.ReadLine());

                    Console.WriteLine("Por quantos meses?");
                    mes = int.Parse(Console.ReadLine());

                    jur = val * tax * mes;

                    Console.WriteLine("O total de juros a ser pago é: {0}", jur);
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Opção errada, tente verificar se digitou corretamente");
                }
            }

            else
            {
                Console.WriteLine("Opção errada, verifique se digitou errado.");
                Console.WriteLine("Lembrando, só pode responder com 1 ou 2.");
                Console.ReadKey();
            }
        }
    }
}