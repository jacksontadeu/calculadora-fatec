
using CalculadoraFatec.src.Model;
using CalculadoraFatec.src.Util;
using System.Net.Http.Headers;

Menu menu = new Menu();

int opcao;
do
{
    menu.MenuPrincipal();

    Console.Write("Digite a opção desejada: ");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            menu.MenuOperacoes();
            Calculadora calc = new Calculadora();
            Console.Write("Número 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a opção: ");
            int operacao = int.Parse(Console.ReadLine());
            if (operacao == 1) Console.WriteLine(calc.Somar(num1, num2));
            else if (operacao == 2) Console.WriteLine(calc.Subtrair(num1, num2));
            else if (operacao == 3) Console.WriteLine(calc.Multiplicar(num1, num2));
            else if (operacao == 4) Console.WriteLine(calc.Dividir(num1, num2));
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Concatenacao concatenar = new Concatenacao();
            Console.WriteLine("Concatenação de Strings");
            Console.WriteLine();
            Console.Write("Digite a 1° palavra: ");
            string pal1 = Console.ReadLine();
            Console.Write("Digite a 2° palavra: ");
            string pal2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(concatenar.ConcString(pal1, pal2));
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Fatorial fatorial = new Fatorial();
            Console.WriteLine("Cálculo de Fatorial");
            Console.WriteLine();
            Console.Write("Digite o número: ");
            int fat = int.Parse(Console.ReadLine());
            Console.WriteLine(fatorial.CalcFatorial(fat));
            Console.ReadKey();
            Console.Clear();
            break;
        case 4: menu.MenuJuros(); break;
        case 5: menu.MenuConversao(); break;
        case 6: break;
        case 0: break;
        default: Console.WriteLine("Opção inválida!!!"); break;
    }

}
while (opcao != 0);