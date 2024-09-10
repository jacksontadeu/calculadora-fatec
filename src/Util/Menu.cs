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
        Console.WriteLine("1 - Operações Básicas");
        Console.WriteLine("2 - Concatenar Strings");
        Console.WriteLine("3 - Fatorial");
        Console.WriteLine("4 - Juros");
        Console.WriteLine("5 - Conversão Base Numéricas");
        Console.WriteLine("6 - Função de Segundo Grau");

    }
    public void MenuOperacoes()
    {
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
    }
    


}
