using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayaShakir.Dominio
{
    public static class ListaVehiculo
    {
        public static Vehiculo BuscarPatenteLinq(List<Vehiculo> lista, string patente)
        {
            return (from l in lista where l.Patente == patente select l).FirstOrDefault();
        }

        public static Vehiculo BuscarPatenteIterativa(List<Vehiculo> lista, string patente)
        {
            foreach (var v in lista)
            {
                if (v.Patente == patente)
                {
                    return v;
                }
            }
            return null;
        }
    }
}
