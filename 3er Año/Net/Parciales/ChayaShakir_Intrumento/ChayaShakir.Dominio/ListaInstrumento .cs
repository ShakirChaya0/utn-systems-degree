using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public class ListaInstrumento
    {
        public static Instrumento BuscarPorMarcaLINQ(List<Instrumento> lista, string marca)
        {
            return (from l in lista where l.Marca == marca select l).FirstOrDefault();
        }
        public static Instrumento BuscarPorAño(List<Instrumento> lista, int año)
        {
            foreach (var l in lista)
            {
                if(l.Año == año)
                {
                    return l;
                }
            }
            return null;
        }

    }
}
