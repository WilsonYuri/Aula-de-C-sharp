using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;
            Console.WriteLine("Escolha um exercício");
            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {
                    case 1:
                    Console.WriteLine("");
                    break;
                    //--
                    case 2:
                    Console.WriteLine("O Console.Read() é usado apenas para leitura de apenas um caractere e retorna com o número decimal mais próximo. \n O Console.ReadLine() é usado para ler um a linha inteira formando uma string");
                    Console.WriteLine("Fonte: https://stackoverflow.com/questions/70867815/the-method-console-read-dont-returns-a-string#:~:text=on%20this%20post.-,Console.,if%20nothing%20could%20be%20read. \n Tabela: https://i.stack.imgur.com/g6col.png");
                    break;
                    //--
                    case 3:
                    Console.WriteLine("Quando faz a leitura de um valor a partir do Console. Ele tem que seguir o tipo de variável correto e pois colocar o tipo de variável correto em no tipo_de_variavel.Parse. Aqui está um tabela.\n char = apenas um caractere \n string = um conjunto de caracteres \n int = numeros inteiros \n float = números com 1 número após a virgula \n double = números com 2 numeros após a virgula");
                    break;
                    //--
                    case 4:
                    Console.WriteLine("Entrando com o número 8 = Mensagem 2 \n Entrando com o número 27 = Mensagem 2 \n Entrando com o número 28 = Mensagem 1");
                    break;
                    //--
                    case 5:
                    Console.Write("Digite a posição inicial: ");
                    double posIN = double.Parse(Console.ReadLine());

                    Console.Write("Digite a velocidade: ");
                    double vel = double.Parse(Console.ReadLine());

                    Console.Write("Digite o tempo: ");
                    double temp = double.Parse(Console.ReadLine());

                    double posFI = posIN + (vel * temp);

                    Console.WriteLine("A posição final é: " + posFI);
                    break;
                    //--
                    case 6:

                    int num;

                    Console.WriteLine("Digite um número inteiro");
                    num = int.Parse(Console.ReadLine());

                    if (num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
                    {
                        Console.WriteLine("E divisível por 3, 5 e 10");
                    }

                    else if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("E divisível por 3 e 5 ");
                    }

                    else if (num % 3 == 0)
                    {
                    Console.WriteLine("É divisível por 3");
                    }

                    else if (num % 5 == 0)
                    {
                    Console.WriteLine("É divisível por 5");
                    }

                    else
                    { 
                        Console.WriteLine("Não é divisível por nenhuma das opções");
                    }
                    break;

                    double km;

                    Console.WriteLine("Digite quantos km");
                    km = double.Parse(Console.ReadLine());

                    if (km <= 100 && km >= 82) 
                    {
                        Console.WriteLine("Ira demorar 12 minutos");
                    }
                    else if (km < 82 && km >= 55)
                    {
                        Console.WriteLine("Ira demorar 27 minutos");
                    }
                    else if (km < 55 && km >= 29)
                    {
                        Console.WriteLine("Iira demorar 40 minutos");
                    }
                    else if (km < 29 && km >= 12)
                    {
                        Console.WriteLine("Ira demorar 57 minutos");
                    }
                    else if (km < 12 && km >= 0)
                    {
                        Console.WriteLine("Irá demorar 71 minutos");
                    }
                    else
                    {
                        Console.WriteLine("o valor não é valido")
                    }
                    break;
            
                    default:
                    Console.WriteLine("Exercício não encontrado. Escreva de 1 à 8");

                    break;
                
            }

            Console.ReadLine();

        }
    }
}
