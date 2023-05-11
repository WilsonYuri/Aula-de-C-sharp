using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------MENU------");
            Console.WriteLine("Digite o exercício que você quer testar");
            Console.WriteLine("Digite 8 para sair");
            Console.WriteLine("------------------\n");

            Console.WriteLine("Escolha o exercício");
            int ex = int.Parse(Console.ReadLine());


            for (; ex != 8;)
            {
                switch (ex)
                {
                    case 1:

                        Console.WriteLine("\nDigite um número inteiro");
                        int iu1 = int.Parse(Console.ReadLine());

                        for (int i = 1; i < iu1 + 1; i++)
                        {
                            Console.Write("{0} ", i);
                        }
                        break;

                    case 2:

                        Console.WriteLine("\nDigite um número inteiro");
                        int iu2 = int.Parse(Console.ReadLine());

                        for (int inf = 1; inf < iu2 + 1; inf++)
                        {
                            if (inf % 2 == 0)
                                Console.Write("{0} ", inf);
                        }
                        break;

                    case 3:

                        Console.WriteLine("\nInforme um número");
                        int iu3 = int.Parse(Console.ReadLine());

                        if (iu3 >= 1000) Console.WriteLine("\nO número deve ser menor que 1000!");

                        for (int i = 1000; i > iu3 - 1; i--)
                        {
                            if (i % 2 == 0)
                                Console.Write("{0} ", i);
                        }
                        break;

                    case 4:

                        int somNum = 0;
                        string posNum = "";

                        for (; somNum < 200;)
                        {
                            Console.WriteLine("\nInforme um número");
                            int iu4 = int.Parse(Console.ReadLine());

                            if (iu4 > -1)
                            {
                                somNum += iu4;
                                posNum += iu4 + " ";
                            }

                        }

                        Console.WriteLine("\nNúmeros positivos informados:\n{0}", posNum);
                        break;

                    case 5:

                        Console.WriteLine("\nInforme um número");
                        int iu5 = int.Parse(Console.ReadLine());
                        string div = "";

                        if (iu5 <= 0)
                        {
                            Console.WriteLine("Número inválido! Deve ser informado um número maior que 0.");
                        }
                        for (int i = 1; i < iu5 + 1; i++)
                        {
                            if (iu5 % i == 0)
                                div += i + " ";
                        }

                        Console.WriteLine("\nOs divisores de {0} são: {1}", iu5, div);
                        break;

                    case 6:

                        int men = 0, mai = 0;

                        for (int i = 0; i < 11; i++)
                        {
                            Console.WriteLine("\nInforme um número");
                            int iu6 = int.Parse(Console.ReadLine());

                            if (i == 0)
                            {
                                men = iu6;
                                mai = iu6;
                            }

                            else if (iu6 > mai) mai = iu6;
                            else if (iu6 < men) men = iu6;
                        }

                        Console.WriteLine("\nMenor número informado: {0}\nMaior número informado: {1}", men, mai);
                        break;

                    case 7:

                        int somPar = 0, somImp = 0;

                        Console.WriteLine("\nInforme um número ou digite 0 para finalizar o programa.");
                        int iu7 = int.Parse(Console.ReadLine());

                        for (; iu7 != 0;)
                        {
                            if (iu7 % 2 == 0) somPar += iu7;
                            else somImp += iu7;

                            Console.WriteLine("\nInforme um número ou digite 0 para finalizar o programa.");
                            iu7 = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("\nSoma dos números pares: " + somPar + "\nSoma do números ímpares: " + somImp);
                        break;

                    default:
                        Console.WriteLine("Exercio invalido!");
                        break;
                }

                Console.WriteLine("------MENU------");
                Console.WriteLine("Digite o exercício que você quer testar");
                Console.WriteLine("Digite 8 para sair");
                Console.WriteLine("------------------\n");

                Console.WriteLine("Escolha o exercício");
                ex = int.Parse(Console.ReadLine());
            }
        }
    }
}



