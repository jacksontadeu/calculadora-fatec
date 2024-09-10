using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CalculadoraFatec.src.Util;
public class Menu
{
    public void MenuPrincipal()
    {
        Console.WriteLine("Menu Calculadora");
        Console.WriteLine();
        Console.WriteLine("1 - Operações Básicas");
        Console.WriteLine("2 - Concatenar Strings");
        Console.WriteLine("3 - Fatorial");
        Console.WriteLine("4 - Juros");
        Console.WriteLine("5 - Conversão Base Numéricas");
        Console.WriteLine("6 - Função de Segundo Grau");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();

    }
    public void MenuOperacoes()
    {
        Console.WriteLine();
        Console.WriteLine("Menu de Operações Básicas");
        Console.WriteLine();
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
    }
    public void MenuJuros()
    {
        Console.WriteLine("1 - Juros Simples");
        Console.WriteLine("2 - Juros Compostos");
    }
    public void MenuConversao()
    {
        Console.WriteLine("B10 X B2");
        Console.WriteLine("B2 X B10");
        Console.WriteLine("B2 X B8");
        Console.WriteLine("B8 X B2");
        Console.WriteLine("B16 X B2");
        Console.WriteLine("B2 X B16");
    }
    


}
