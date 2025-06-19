using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public class ListaDispositivo
    {
        public static Dispositivo BuscarNroSerieLinq(List<Dispositivo> lista, string nroSerie)
        {
            return (from l in lista where l.NroSerie == nroSerie select l).FirstOrDefault();
        }

        public static Dispositivo BuscarNroSerieIterativa(List<Dispositivo> lista, string nroSerie) 
        { 
            foreach(var l in lista)
            {
                if (l.NroSerie == nroSerie)
                {
                    return l;
                }
            }
            return null;
        }
    }
}
