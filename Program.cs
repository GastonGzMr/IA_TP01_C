using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP01_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            diccionario.Add("Izquierda", "Limpio");
            diccionario.Add("Derecha", "Limpio");
            Aspiradora aspiradora = new Aspiradora(diccionario);
        }
    }
}
