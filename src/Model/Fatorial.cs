using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculadoraFatec.src.Model;
public class Fatorial
{
    public long Numero { get; set; }


    public long CalcFatorial(long numero)
    {
        int fat = 1;
        for (int i = 1; i <= numero; i++)
        {
            fat = fat * i;
        }
        return fat;
    }
}
