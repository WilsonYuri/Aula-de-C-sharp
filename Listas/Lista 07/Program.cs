using System;

namespace Lista_07
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int p;
            Console.WriteLine("Qual programa que você deseja executar? ");
            p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1:

                    int prod, prec, tot = 0;

                    while (true)
                    {

                        Console.WriteLine("Qual é o quantidade desse produto ");
                        prod = int.Parse(Console.ReadLine());

                        if (prod == 0)
                        {
                            break;
                        }
                        Console.WriteLine("Qual é o preço do produto: ");
                        prec = int.Parse(Console.ReadLine());

                        tot = prec * prod + tot;

                        if (tot == 0)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("o valor total vai igual a:" + tot);
                    break;

                case 2:


                    double vl, qq, vtt, vm, vmm;
                    string nom, nm, nmm;

                    Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");
                    nom = Console.ReadLine();

                    if (nom == "parar")
                    {
                        break;
                    }

                    Console.WriteLine("digite o valor do produto por unidade");
                    vl = double.Parse(Console.ReadLine());

                    Console.WriteLine("digite o a quantidade do produto");
                    qq = double.Parse(Console.ReadLine());

                    vtt = qq * vl;
                    vm = vtt;
                    nm = nom;
                    vmm = vtt;
                    nmm = nom;

                    while (nom != "parar")

                    {
                        Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");
                        nom = Console.ReadLine();

                        if (nom == "parar")
                        {
                            break;
                        }

                        Console.WriteLine("digite o valor do produto por unidade");
                        vl = double.Parse(Console.ReadLine());

                        Console.WriteLine("digite o a quantidade do produto");
                        qq = double.Parse(Console.ReadLine());

                        vtt = qq * vl;

                        if (vtt > vm)
                        {
                            nm = nom;
                        }

                        if (vtt < vmm)
                        {
                            nmm = nom;
                        }
                        int k = 0;
                        k++;
                    }

                    Console.WriteLine("o produto com maior investimento é: " + nm + " com um investimento de R$" + vm + " e o de menor investimento é: " + nmm + " com um investimento de R$" + vmm);

                    break;

                case 3:

                    double ava, pes, pon;

                    Console.WriteLine("Quantas avaliações vão ter nesse bimestre?");
                    ava = double.Parse(Console.ReadLine());

                    pon = 0;
                    int i = 0;
                    while (i < ava)

                    {

                        Console.WriteLine("Qual é o peso das avaliações");
                        pes = double.Parse(Console.ReadLine());

                        pon = pon + pes;
                        i++;

                    }

                    pon = pon * 10;

                    if (pon > 100)
                    {
                        Console.WriteLine("\nOs pesos são maiores que 100%");
                        break;
                    }

                    if (pon == 100)
                    {
                        Console.WriteLine("\nOs pesos ficam em 100%");
                        break;

                    }

                    if (pon > 100)
                    {
                        Console.WriteLine("\nOs pesos não chegam à 100%");
                        break;

                    }

                    break;

                case 4:

                    string est;

                    Console.WriteLine("qual a sigla do estado");
                    est = Console.ReadLine();

                    switch (est)

                    {

                        case "AC":
                            Console.WriteLine("o estado é: Acre");

                            break;

                        case "AL":
                            Console.WriteLine("o estado é: Alagoas");

                            break;

                        case "AP":
                            Console.WriteLine("o estado é: Amapá");

                            break;

                        case "AM":
                            Console.WriteLine("o estado é: Amazonas");

                            break;

                        case "BA":
                            Console.WriteLine("o estado é: Bahia");

                            break;

                        case "CE":
                            Console.WriteLine("o estado é: Ceará");

                            break;

                        case "DF":
                            Console.WriteLine("Distrito Federal");

                            break;

                        case "ES":
                            Console.WriteLine("o estado é: Espírito Santo");

                            break;

                        case "GO":
                            Console.WriteLine("o estado é: Goiás");

                            break;

                        case "MA":
                            Console.WriteLine("o estado é: Maranhão");

                            break;

                        case "MT":
                            Console.WriteLine("o estado é: Mato Grosso");

                            break;

                        case "MS":
                            Console.WriteLine("o estado é: Mato Grosso do Sul");

                            break;

                        case "MG":
                            Console.WriteLine("o estado é: Minas Gerais");

                            break;

                        case "PA":
                            Console.WriteLine("o estado é: Pará");

                            break;

                        case "PB":
                            Console.WriteLine("o estado é: Paraíba");

                            break;

                        case "PR":
                            Console.WriteLine("o estado é: Paraná");

                            break;

                        case "PE":
                            Console.WriteLine("o estado é: Pernambuco");

                            break;

                        case "PI":
                            Console.WriteLine("o estado é: Piauí");

                            break;

                        case "RJ":
                            Console.WriteLine("o estado é: Rio de Janeiro");

                            break;

                        case "RN":
                            Console.WriteLine("o estado é: Rio Grande do Norte");

                            break;

                        case "RS":
                            Console.WriteLine("o estado é: Rio Grande do Sul");

                            break;

                        case "RO":
                            Console.WriteLine("o estado é: Rondônia");

                            break;

                        case "RR":
                            Console.WriteLine("o estado é: Roraima");

                            break;

                        case "SC":
                            Console.WriteLine("o estado é: Santa Catarina");

                            break;

                        case "SP":
                            Console.WriteLine("o estado é: São Paulo");

                            break;

                        case "SE":
                            Console.WriteLine("o estado é: Sergipe");

                            break;

                        case "TO":
                            Console.WriteLine("o estado é: Tocantins");

                            break;

                        default:
                            Console.WriteLine("nao existe estado com essa sigla");

                            break;

                    }

                    break;

                case 5:

                    int mes, dia;

                    Console.WriteLine("Digite o mês");
                    mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {

                        case 1:
                            Console.WriteLine("a estação correspondente a este mês é: verão");
                            break;

                        case 2:
                            Console.WriteLine("a estação correspondente a este mês é: verão");
                            break;

                        case 3:
                            Console.WriteLine("qual é o dia?");
                            dia = int.Parse(Console.ReadLine());

                            if (dia < 20 && dia > 1)
                                Console.WriteLine("a estação correspondente a este mês é: verão");

                            if (dia >= 20 && dia < 31)
                                Console.WriteLine("a estação correspondente a este mês é: outono");

                            break;

                        case 4:
                            Console.WriteLine("a estação correspondente a este mês é: verão");
                            break;

                        case 5:
                            Console.WriteLine("a estação correspondente a este mês é: verão");
                            break;

                        case 6:

                            Console.WriteLine("qual é o dia?");

                            dia = int.Parse(Console.ReadLine());

                            if (dia < 21 && dia > 1)
                                Console.WriteLine("A estação desse este mês é: Outono");

                            if (dia >= 21 && dia < 30)
                                Console.WriteLine("A estação desse este mês é: Inverno");

                            break;

                        case 7:

                            Console.WriteLine("A estação desse este mês é: Inverno");
                            break;

                        case 8:

                            Console.WriteLine("A estação desse este mês é: Inverno");
                            break;

                        case 9:

                            Console.WriteLine("qual é o dia?");
                            dia = int.Parse(Console.ReadLine());

                            if (dia < 23 && dia > 1)
                                Console.WriteLine("A estação desse este mês é: inverno");

                            if (dia >= 23 && dia < 30)
                                Console.WriteLine("A estação desse este mês é: primavera");

                            break;

                        case 10:
                            Console.WriteLine("A estação desse este mês é: Primavera");
                            break;

                        case 11:
                            Console.WriteLine("A estação desse este mês é: primavera");
                            break;

                        case 12:

                            Console.WriteLine("Qual é o dia?");
                            dia = int.Parse(Console.ReadLine());

                            if (dia < 22 && dia > 1)
                                Console.WriteLine("A estação desse este mês é: Primavera");

                            if (dia >= 22 && dia < 30)
                                Console.WriteLine("A estação desse este mês é: Verão");

                            break;

                        default:

                            Console.WriteLine("O valor digitado não é válido!");

                            break;

                    }

                    break;

                case 6:

                    double hei, wei, imc;

                    Console.WriteLine("Digite sua altura: ");
                    hei = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite seu peso: ");
                    wei = double.Parse(Console.ReadLine());

                    imc = wei / (hei * hei);

                    if (imc < 18.5)
                    {
                        Console.WriteLine("você está abaixo do peso");
                        break;
                    }

                    if (imc >= 18.5 && imc <= 24.9)
                    {
                        Console.WriteLine("você está no peso comum");
                        break;
                    }

                    if (imc >= 25 && imc <= 29.9)
                    {
                        Console.WriteLine("você está acima do peso");
                        break;
                    }

                    if (imc >= 30 && imc < 34.9)
                    {
                        Console.WriteLine("você está com obesidade grau 1");
                        break;
                    }

                    if (imc >= 35 && imc < 39.9)
                    {
                        Console.WriteLine("você está com obesidade grau 2");
                        break;
                    }

                    if (imc >= 40)
                    {
                        Console.WriteLine("você está com obesidade grau 3");
                        break;
                    }

                    break;

                case 7:

                    int num;

                    Console.WriteLine("Digite um número");

                    num = int.Parse(Console.ReadLine());
                    int b = 1;
                    while (b < num)

                    {
                        b++;
                        if (num % b == 0)
                            Console.WriteLine(b);

                        else
                             b++;

                    }

                    break;

                default:
                    Console.WriteLine("Número não válido");

                    break;

            }

        }

    }

}
