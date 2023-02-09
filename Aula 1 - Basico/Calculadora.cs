using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            string op;
            int res = 0;

            Console.WriteLine("Digite um número");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação? +, -, /, *");
            op = Console.ReadLine();

            //int soma = numero + numero;
            //Console.WriteLine(soma);

            if (op.Equals("+"))
            {
                res = numero1 + numero2;
                Console.WriteLine("O Resultado é {0}", res);
            }

            else if (op.Equals("-"))
            {
                res = numero1 - numero2;
                Console.WriteLine("O Resultado é {0}", res);
            }

            else if (op.Equals("/"))
            {
                res = numero1 / numero2;
                Console.WriteLine("O Resultado é {0}", res);
            }

            else if (op.Equals("+"))
            {
                res = numero1 * numero2;
                Console.WriteLine("O Resultado é {0}", res);
            }

            else
            {
                Console.WriteLine("Operação não existente");
            }

            Console.ReadKey();
        }
    }
}
