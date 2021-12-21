using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP01_C
{
    public class Aspiradora
    {
        public Dictionary<string,string> Memoria { get; set; }
        
        public Aspiradora(Dictionary<string, string> pEstadoInicial)
        {
            Memoria = pEstadoInicial;
        }
        
        public void Activar(Percepcion percepcion)
        {
            Memoria[percepcion.Direccion] = percepcion.Descripcion;
            Accion accion = DecidirAccion();
            RealizarAccion(accion);
        }

        public Accion DecidirAccion()
        {
            Accion accion = new Accion();
            foreach (string key in Memoria.Keys)
            {
                if (Memoria[key].Equals("Sucio"))
                {
                    accion.Descripcion = "Limpiar";
                    accion.Direccion = key;
                    return accion;
                }
            }
            accion.Descripcion = "Esperar";
            accion.Direccion = "";
            return accion;
        }

        public void RealizarAccion(Accion accion)
        {
            if (accion.Descripcion.Equals("Limpiar"))
            {
                Memoria[accion.Direccion] = "Limpio";
            }
        }
    }
}
