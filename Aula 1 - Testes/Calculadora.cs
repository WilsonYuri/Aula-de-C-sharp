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

            Console.WriteLine("Digite um n�mero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro n�mero");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual opera��o? +, -, /, *");
            op = Console.ReadLine();

            if (op.Equals("+"))
            {
                res = numero1 + numero2;
                Console.WriteLine("O Resultado � {0}", res);
            }

            else if (op.Equals("-"))
            {
                res = numero1 - numero2;
                Console.WriteLine("O Resultado � {0}", res);
            }

            else if (op.Equals("/"))
            {
                res = numero1 / numero2;
                Console.WriteLine("O Resultado � {0}", res);
            }

            else if (op.Equals("+"))
            {
                res = numero1 * numero2;
                Console.WriteLine("O Resultado � {0}", res);
            }

            else
            {
                Console.WriteLine("Opera��o n�o existente");
            }

            Console.ReadKey();
        }
    }
}
