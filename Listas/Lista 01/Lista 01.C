using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma questão de 1 à 13:");

            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Digite uma quantidade em metros:");
                double metr = double.Parse(Console.ReadLine());

                double cen = metr * 100;
                double mil = metr * 1000;

                Console.WriteLine("Essa quantidade de metros dá {0} centímetros", cen);
                Console.WriteLine("Essa quantidade de metros dá {0} milímetros", mil);

                Console.ReadLine();
            }

            //----------------

            else if (op == 2)
            {
                Console.WriteLine("Digite um valor em graus Fahrenheit:");

                float f = float.Parse(Console.ReadLine());

                float c = (f - 32.0f) * (5.0f / 9.0f);

                Console.WriteLine("{0} graus Fahrenheit equivale a {1} graus Celsius", f, c);
                Console.WriteLine();
                Console.WriteLine("Ele ia dar o resultado como 0 por causa que 5/9 da 0.555 e int aredonda os número, fazendo com que 0.555 vire 0");

                Console.ReadLine();
            }

            //----------------

            else if (op == 3)
            {
                Console.WriteLine("Digite sua altura em metros:");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso em quilogramas:");
                double peso = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine("Seu IMC é {0}.", imc);

                if (imc < 18.5)
                {
                    Console.WriteLine("Você está abaixo do peso.");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("Seu peso está normal.");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("Você está com sobrepeso.");
                }
                else
                {
                    Console.WriteLine("Você está obeso.");
                }

                Console.ReadLine();
            }

            //-------------

            else if (op == 4)

            {
                float pes1, pes2, pes3, med;

                Console.WriteLine("informe o peso da primeira pessoa:");
                pes1 = float.Parse(Console.ReadLine());

                Console.WriteLine("informe o peso da seguanda pessoa:");
                pes2 = float.Parse(Console.ReadLine());

                Console.WriteLine("informe o peso da terceira pessoa:");
                pes3 = float.Parse(Console.ReadLine());

                med = (pes1 + pes2 + pes3) / 3;
                Console.WriteLine("a media de peso é {0}", med);

                Console.ReadLine();
            }

            // ----------------

            else if (op == 5)
            {
                Console.WriteLine("Digite a distância em km:");
                double dis = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a velocidade média em km/h:");
                double vel = double.Parse(Console.ReadLine());

                double tem = dis / vel;

                Console.WriteLine("O tempo quem precisa para percorrer {0} km a uma velocidade média de {1} km/h é de {2} horas.", dis, vel, tem);

                Console.ReadLine();
            }

            // ---------------------

            else if (op == 6)
            {
                Console.WriteLine("Digite o salário atual:");
                double sal = double.Parse(Console.ReadLine());

                // Calcula o novo salário com um aumento de 25%
                double res = sal * 1.25;

                // Apresenta o resultado
                Console.WriteLine("O novo salário com um aumento de 25% é de {0} reais.", res);

                Console.ReadLine();
            }
            else if (op == 7)
            {
                Console.WriteLine("Digite o valor em reais:");
                double real = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a cotação do dólar:");
                double cot = double.Parse(Console.ReadLine());

                double dol = real / cot;

                Console.WriteLine("O valor de {0} reais em dólar é de {1}, considerando que a cotação do dólar é de {2} reais.", real, dol, cot);

                Console.ReadLine();

            }
            else if (op == 8)
            {
                float num, sus, ant, res;

                Console.WriteLine("Digite um número");
                num = float.Parse(Console.ReadLine());

                sus = (num * 3) + 1;
                ant = (num * 2) - 1;
                res = ant + sus;

                Console.WriteLine("o resultado é"+ res);

            }
            else if (op == 9)
            {
                Console.WriteLine("Digite um número de 4 dígitos:");
                int num = int.Parse(Console.ReadLine());

                int num1, num2, num3, num4;

                num1 = (num / 1000);
                num2 = ((num / 100) % 10);
                num3 = ((num / 10) % 10);
                num4 = (num % 10);


                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
                Console.WriteLine(num4);
            }
            else if (op == 10)
            {
                double inv = 1000.0;

                inv *= (1 - 0.034); // -3,4%
                inv *= (1 + 0.028); // +2,8%
                inv *= (1 + 0.14); // +14%
                inv *= (1 - 0.085); // -8,5%
                Console.WriteLine("O atual valor do investimento de Marquesito é R${0}.", inv);
            }
            else if (op == 11)
            {
                Console.WriteLine("Digite um número inteiro:");
                int num = int.Parse(Console.ReadLine());

                int cub, qua;

                cub = (num * num);
                qua = (num * num * num);

                Console.WriteLine("O número {0} ao quadrado é {1}.", num, cub);
                Console.WriteLine("O número {0} ao cubo é {1}.", num, qua);

            }

            else if (op == 12)
            {
                Console.WriteLine("Digite a altura da pessoa em metros:");
                double alt = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o sexo da pessoa (M ou F):");
                char sex = char.Parse(Console.ReadLine());

                
                double pes;
                if (sex == 'M')
                {
                    pes = 72.7 * alt - 58;
                }

                else if (sex == 'F')
                {
                    pes = 62.1 * alt - 44.7;
                }

                else
                {
                    Console.WriteLine("Sexo inválido.");
                    return;
                }

                Console.WriteLine("O peso ideal da pessoa é de {0} kg.", pes);
            }
            else if (op == 13)
            {
                Console.WriteLine("GIT é um sistema que controla as versões de software, versionando as mudanças realizadas em um projeto ao longo do tempo. Equipes podem trabalhar ao mesmo tempo no mesmo código-fonte e gerenciar as diferentes versões e os conflitos gerados por essas versões de forma eficiente.");
                Console.WriteLine("O GitHub é uma 'rede social para programadores(Além do Stack OverFlow)' que hospeda repositórios de código GIT, permitindo que desenvolvedores participem em projetos abertos ou privados");
                Console.WriteLine();
                Console.WriteLine("Alguns dos comandos mais conhecidos de GIT são : push, pull, merge, commit, add, branch, fetch, log, init, sync");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

                Console.ReadLine();
            }
        }

    }

