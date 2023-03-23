using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1

            //float num, res;

            //Console.WriteLine("Quantas laranjas você quer? ");
            //num = float.Parse(Console.ReadLine());

            //if (num <= 11){ 

            //    res = num * 0.35f;
            //    Console.WriteLine(" o valor sera de: "+ res);

            //}
            //else
            //{
            //    res = num * 0.28f;
            //    Console.WriteLine("o valor vai ser {0} reais", res);
            //}
            //Console.ReadKey();

            //exercicio 2

            //int age, res;

            //Console.WriteLine("Que ano Você nasceu? ");
            //age = int.Parse(Console.ReadLine());

            //res = 2026 - age;
            //if (res >= 16)
            //{
            //    Console.WriteLine("Você pode votar ");
            //}
            //else
            //{
            //    Console.WriteLine("Você não pode votar");
            //}
            //Console.ReadKey();


            //exercicio 3

            //int A, B, C;

            //Console.WriteLine("qual o valor do lado a? ");
            //A=int.Parse(Console.ReadLine());

            //Console.WriteLine("qual o valor do lado b? ");
            //B=int.Parse(Console.ReadLine());

            //Console.WriteLine("qual o valor do lado c? ");
            //C=int.Parse(Console.ReadLine());

            //if (A == B && B == C)
            //{
            //    Console.WriteLine("o triangulo é equilatero");
            //}
            //else if (A == C && B != C || C == B && A != B || A == B && C != B)
            //    {
            //        Console.WriteLine("o triangulo é isoceles");
            //    }

            //    else {
            //        Console.WriteLine("o triangulo é escaleno ");
            //    }
            //}
            //Console.ReadKey();

            //exercicio 4
            //double A, B, C, delt;

            //Console.Write("Digite o valor de A: ");
            //A = double.Parse(Console.ReadLine());

            //Console.Write("Digite o valor de B: ");
            //B = double.Parse(Console.ReadLine());

            //Console.Write("Digite o valor de C: ");
            //C = double.Parse(Console.ReadLine());


            //delt = Math.Pow(B, 2) - 4 * A * C;


            //if (delt < 0)
            //{
            //    Console.WriteLine("A equação não possui raízes reais");
            //}
            //else
            //{
            //    // Calcula as raízes
            //    double x1 = (-B + Math.Sqrt(delt)) / (2 * A);
            //    double x2 = (-B - Math.Sqrt(delt)) / (2 * A);


            //    Console.WriteLine("As raízes da equação são: x1 = " + x1 + ", x2 = " + x2);
            //}


            // exercicio 5

            //float num;

            //Console.WriteLine("qual o numero? ");
            //num = float.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("o número é divisivel por 5 e 3 ");
            //}
            //else
            //{
            //    if (num % 5 == 0)
            //    {
            //        Console.WriteLine("o número é divisivel por 5");
            //    }
            //
            //    else
            //    {
            //        Console.WriteLine("o número é divisivel por 3");
            //    }
            //}
            //Console.ReadKey();


            //exercicio 6

            //float ang1, ang2, ang3;

            //Console.WriteLine("qual o valor do 1 ângulo? ");
            //ang1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do 2 ângulo? ");
            //ang2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o valor do 3 Ângulo? ");
            //ang3 = float.Parse(Console.ReadLine());

            //if (ang1 == 90 || ang2 == 90 || ang3 == 90)
            //{
            //    Console.WriteLine("é um triangulo Retangulo");
            //}
            //else
            //{
            //    if(ang1 <90 && ang2<90 && ang3 < 90)
            //    {
            //        Console.WriteLine("é um triangulo Acutangulo");
            //    }
            //    else
            //    {
            //        Console.WriteLine("é um triangulo Obtusangulo");
            //    }
            //}
            //Console.ReadKey();

            //exercicio 7
            //int val1, val2, val3;

            //Console.Write("Digite o primeiro valor: ");
            //val1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo valor: ");
            //val2 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o terceiro valor: ");
            //val3 = int.Parse(Console.ReadLine());


            //if (val1 > val2)
            //{
            //    val1 = val1 + val2;
            //    val2 = val1 - val2;
            //    val1 = val1 - val2;
            //}
            //if (val1 > val3)
            //{
            //    val1 = val1 + val3;
            //    val3 = val1 - val3;
            //    val1 = val1 - val3;
            //}


            //if (val2 > val3)
            //{
            //    val2 = val2 + val3;
            //    val3 = val2 - val3;
            //    val2 = val2 - val3;
            //}


            //Console.WriteLine("Valores em ordem crescente: " + val1 + ", " + val2 + ", " + val3);

            //Console.ReadKey();


            //exercicio 8


            //int year;
            //Console.Write("Digite um year: ");
            //year = int.Parse(Console.ReadLine());


            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine(year + " é um ano bissexto");
            //}
            //else
            //{
            //    Console.WriteLine(year + " não é um ano bissexto");
            //}

            //Console.ReadKey();


            //exercicio 9
            //char op;
            //double num1, num2;
            //Console.Write("Digite o primeiro número: ");
            //num1 = double.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo número: ");
            //num2 = double.Parse(Console.ReadLine());


            //Console.Write("Digite o caractere da operação (+, -, *, /): ");
            //op = char.Parse(Console.ReadLine());


            //double res = 0;
            //if (op == '+')
            //{
            //    res = num1 + num2;
            //}
            //if (op == '-')
            //{
            //    res = num1 - num2;
            //}
            //if (op == '*')
            //{
            //    res = num1 * num2;
            //}
            //if (op == '/')
            //{
            //    res = num1 / num2;
            //}
            //if (op != '+' && op != '-' && op != '*' && op != '/')
            //{
            //    Console.WriteLine("operador inválido!");
            //}
            //else
            //{
            //    Console.WriteLine("resultado da operação: " + res);
            //}
            //Console.ReadKey();


            //exercicio 10

            //Em C#, números inteiros e reais aleatórios podem ser gerados utilizando a classe Random. O método Next é usado para gerar números inteiros aleatórios dentro de um intervalo, enquanto NextDouble é usado para gerar números reais aleatórios entre 0 e 1. Para gerar um número real aleatório dentro de um intervalo específico, basta multiplicar o número gerado pelo tamanho do intervalo desejado e somar o valor mínimo do intervalo. Lembre-se de que os números gerados são pseudorandomicos e que é recomendado usar uma única instância de Random em todo o programa.
        }
    }
}