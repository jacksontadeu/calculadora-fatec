using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFatec.src.Model;
public class Concatenacao
{
    public string Palavra1 { get; set; }
    public string Palavra2 { get; set; }

    public string ConcString(string palavra1, string palavra2)
    {
        return palavra1 + palavra2;
    }

}
