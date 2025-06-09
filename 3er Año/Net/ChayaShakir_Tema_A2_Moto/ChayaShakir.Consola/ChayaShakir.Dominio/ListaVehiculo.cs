using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public class ListaVehiculo
    {
        public static Vehiculo BuscarPatenteLINQ(List<Vehiculo> lista, string patente)
        {
            return (from l in lista where l.Patente == patente select l).FirstOrDefault();
        }
        public static Vehiculo BuscarPatenteIterativa(List<Vehiculo> lista, string patente)
        {
            foreach (var l in lista)
            {
                if (l.Patente == patente)
                {
                    return l;
                }
            }
            return null;
        }
    }
}

