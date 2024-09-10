using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFatec.src.Model;
public class Calculadora
{
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

    public double Somar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }
    public double Subtrair(double numero1, double numero2)
    {
        return numero1 - numero2;
    }
    public double Multiplicar(double numero1, double numero2)
    {
        return numero1 * numero2;
    }
    public double Dividir(double numero1, double numero2)
    {
        if (numero1 == 0 || numero2 == 0)
        {
            Console.WriteLine("Impossivel divisão por zero!!!");
            return 0;
        } 
        else
            return numero1 / numero2;
    }
}
