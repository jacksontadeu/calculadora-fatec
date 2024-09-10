
using CalculadoraFatec.src.Util;
using System.Net.Http.Headers;

Menu menu = new Menu();

menu.MenuPrincipal();

Console.Write("Digite a opção desejada: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1: menu.MenuOperacoes(); break;
    case 2: break;
    case 3: break;
    case 4: break;
    case 5: break;
    case 6: break;
}