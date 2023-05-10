using System;

namespace Lista3PR2
{
    internal class Program
        {
            static void Main(string[] args)
            {
                int ex;

                Console.WriteLine("Qual o exercicio: ");
                ex = int.Parse(Console.ReadLine());

                switch (ex)
                {

                    case 1:
                        int dia;

                        Console.WriteLine("Exercicio 1");
                        Console.WriteLine("Qual o dia da semana ? : ");
                        dia = int.Parse(Console.ReadLine());

                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("Esse dia é o Domingo");
                                break;

                            case 2:
                                Console.WriteLine("Esse dia é a Segunda-Feira");
                                break;

                            case 3:
                                Console.WriteLine("Esse dia é a Terça-Feira");
                                break;

                            case 4:
                                Console.WriteLine("Esse dia é a Quarta-Feira");
                                break;

                            case 5:
                                Console.WriteLine("Esse dia é a Quinta-Feira");
                                break;

                            case 6:
                                Console.WriteLine("Esse dia é a Sexta-Feira");
                                break;

                            case 7:
                                Console.WriteLine("Esse dia é o Sabado");
                                break;

                            default:
                                Console.WriteLine("Não existe esse dia ");
                                break;

                        }
                        break;

                    case 2:

                        double com, pag, tot;

                        Console.WriteLine("Exercicio 2");
                        Console.WriteLine("Qual o valor em que ficou sua compra?");
                        com = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o método de pagamento?");
                        Console.WriteLine("1 - Dinheiro ? ");
                        Console.WriteLine("2 - Pix ? ");
                        Console.WriteLine("3 - Cartão de débito ? ");
                        Console.WriteLine("4 - Cartão de Crédito ?");

                        pag = double.Parse(Console.ReadLine());

                        switch (pag)
                        {
                            case 1:
                                tot = com * 0.85;
                                Console.WriteLine("O valor da sua compra é de: " + tot);
                                break;

                            case 2:
                                tot = com * 0.90;
                                Console.WriteLine("O valor da sua compra é de: " + tot);
                                break;

                            case 3:
                                tot = com * 1.05;
                                Console.WriteLine("O valor da sua compra é de: " + tot);
                                break;

                            case 4:
                                tot = com * 1.10;
                                Console.WriteLine("O valor da sua compra é de: " + tot);
                                break;

                            default:
                                Console.WriteLine("Não aceitamos esse tipo de pagamento !");
                                break;
                        }
                        break;

                    case 3:
                        int mes;
                        string ybi;

                        Console.WriteLine("O seu ano é bissexto? ");
                        ybi = Console.ReadLine();

                        if (ybi == "sim")
                            {
                                Console.WriteLine("Escreva o numero correspondente do mês: ");
                                mes = int.Parse(Console.ReadLine());

                                switch (mes)
                                {
                                    case 1:

                                        Console.WriteLine("Janeiro, 31 dias");
                                        break;
                                    case 2:

                                        Console.WriteLine("Fevereiro, 29 dias");
                                        break;
                                    case 3:

                                        Console.WriteLine("Março, 31 dias");
                                        break;
                                    case 4:

                                        Console.WriteLine("Abril, 30 dias");
                                        break;
                                    case 5:

                                        Console.WriteLine("Maio, 31 dias");
                                        break;
                                    case 6:

                                        Console.WriteLine("Junho, 30 dias");
                                        break;
                                    case 7:

                                        Console.WriteLine("Julho, 31 dias");
                                        break;
                                    case 8:

                                        Console.WriteLine("Agosto, 31 dias");
                                        break;
                                    case 9:

                                        Console.WriteLine("Setembro, 30 dias");
                                        break;
                                    case 10:

                                        Console.WriteLine("Outubro, 31 dias");
                                        break;
                                    case 11:

                                        Console.WriteLine("Novembro, 30 dias");
                                        break;
                                    case 12:

                                        Console.WriteLine("Dezembro, 31 dias");
                                        break;

                                    default:
                                        Console.WriteLine("Número errado. Escolha um mês de 1 à 12");
                                        break;

                                }
                            }

                            else
                            {
                                Console.WriteLine("Escreva o número do mês: ");
                                mes = int.Parse(Console.ReadLine());

                                switch (mes)
                                {
                                    case 1:

                                        Console.WriteLine("Janeiro, 31 dias");
                                        break;
                                    case 2:

                                        Console.WriteLine("Fevereiro, 28 dias");
                                        break;
                                    case 3:

                                        Console.WriteLine("Março, 31 dias");
                                        break;
                                    case 4:

                                        Console.WriteLine("Abril, 30 dias");
                                        break;
                                    case 5:

                                        Console.WriteLine("Maio, 31 dias");
                                        break;
                                    case 6:

                                        Console.WriteLine("Junho, 30 dias");
                                        break;
                                    case 7:

                                        Console.WriteLine("Julho, 31 dias");
                                        break;
                                    case 8:

                                        Console.WriteLine("Agosto, 31 dias");
                                        break;
                                    case 9:

                                        Console.WriteLine("Setembro, 30 dias");
                                        break;
                                    case 10:

                                        Console.WriteLine("Outubro, 31 dias");
                                        break;
                                    case 11:

                                        Console.WriteLine("Novembro, 30 dias");
                                        break;
                                    case 12:

                                        Console.WriteLine("Dezembro, 31 dias");
                                        break;
                                    default:
                                        Console.WriteLine("Número errado. Escolha um mês de 1 à 12");
                                        break;

                                }
                            }
                        break;

                    case 4:


                        char op;
                        int num1, num2;


                        Console.WriteLine("Escreva o primeiro numero? ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escreva o segundo numero? ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a operaçao desejada ? (+, -, /, *)");
                        op = char.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case '+':
                                Console.WriteLine(num1 + num2);
                                break;

                            case '-':
                                Console.WriteLine(num1 - num2);
                                break;

                            case '*':
                                Console.WriteLine(num1 * num2);
                                break;

                            case '/':
                                Console.WriteLine(num1 / num2);
                                break;

                            default:
                                Console.WriteLine("Operaçao nao existente!");
                                break;
                        }

                        break;

                    case 5:

                        double code, sal, nov, res;

                        Console.WriteLine("Qual o codigo do seu cargo ? ");
                        code = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o seu salario atual ? ");
                        sal = double.Parse(Console.ReadLine());

                        switch (code)
                        {
                            case 101:

                        nov = sal * 1.075;
                        res = nov % sal;
                        Console.WriteLine("O salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    case 102:

                        nov = sal * 1.097;
                        res = sal - nov;
                        Console.WriteLine("O salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    case 103:

                        nov = sal * 1.117;
                        res = nov - sal;
                        Console.WriteLine("O salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    case 204:

                        nov = sal * 1.089;
                        res = nov - sal;
                        Console.WriteLine("O salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    case 206:

                        nov = sal * 1.1324;
                        res = nov - sal;
                        Console.WriteLine("O salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    case 301:

                        nov = sal * 1.104;
                        res = nov - sal;
                        Console.WriteLine("O salário era de: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    case 302:

                        nov = sal * 1.146;
                        res = nov - sal;
                        Console.WriteLine("O salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;

                    default:
                        nov = sal * 1.435;
                        res = nov - sal;
                        Console.WriteLine("O seu salário era: R$" + sal + ", o novo salario é de: R$" + nov + " e a diferença é de: R$" + res);
                        break;
                }
                break;

                    case 6:
                        double sala, liq, impos;

                Console.WriteLine("Qual o salario atual ?");
                sal = double.Parse(Console.ReadLine());

                if (sal < 1903.98)
                {
                    Console.WriteLine("O salário você não paga imposto de renda");
                }
                else if (sal >= 1903.99 && sal <= 2826.65)
                {
                    liq = sal - sal * 0.075;
                    impos = sal % liq;
                    Console.WriteLine("O seu salário líquido é de: R$" + liq + " , e o imposto foi de: R$" + impos);
                }
                else if (sal >= 2826.66 && sal <= 3751.05)
                {
                    liq = sal - sal * 0.15;
                    impos = sal % liq;
                    Console.WriteLine("Seu salário líquido é de: R$" + liq + " , e o imposto foi de: R$" + impos);
                }
                else if (sal >= 3751.06 && sal <= 4664.68)
                {
                    liq = sal - sal * 0.225;
                    impos = sal % liq;
                    Console.WriteLine("Seu salário líquido é de: R$" + liq + " , e o imposto foi de: R$" + impos);
                }
                else
                {
                    liq = sal - sal * 0.275;
                    impos = sal % liq;
                    Console.WriteLine("Seu salário líquido é de: R$" + liq + " , e o imposto foi de: R$" + impos);
                }
                break;


                default:
                        Console.WriteLine("Opção invalida!");
                break;


            }
        }
    }
}
    