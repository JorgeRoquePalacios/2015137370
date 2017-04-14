using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
           
                SimularVentas sim= new SimularVentas();
                List<Venta> ListaVentas = sim.getlistaVentas();
                Reporte libp = new Reporte();
                libp.ReporteVentas(ListaVentas);





        }
    }
}
