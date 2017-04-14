using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Reporte
    {
        

        public void ReporteVentas(List<Venta> listaVentas)
        {
            Console.WriteLine("Reporte de Ventas");
            Console.WriteLine();
            Console.WriteLine("Pasajes");
            Console.WriteLine( "NroBoleto".PadRight(11) +"Tipo Viaje".PadRight(12)+ "Origen".PadRight(8) + "Destino".PadRight(11) + "TipoComprobante".PadRight(16) + "TipoPago".PadRight(12)+"Monto".PadRight(6));

            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].servicio.tiposervicio == TipoServicio.Transporte)
                {
                    Transporte transporte = (Transporte)listaVentas[i].servicio;
                    Console.WriteLine(transporte.getNroBoleto().ToString().PadRight(11) + transporte.getTipoViaje().ToString().PadRight(12) + transporte.getOrigen().PadRight(8) + transporte.getDestino().PadRight(11) + listaVentas[i].tipocomprobante.ToString().PadRight(16) + listaVentas[i].tipopago.ToString().PadRight(12) + transporte.getMonto().ToString().PadRight(6));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Encomiendas");
            Console.WriteLine("NroEncomienda".PadRight(15) + "Origen".PadRight(8) + "Destino".PadRight(14) + "TipoComprobante".PadRight(16) + "TipoPago".PadRight(12) + "Monto".PadRight(6));

            for (int i = 0; i < listaVentas.Count; i++)
            {
                if (listaVentas[i].servicio.tiposervicio == TipoServicio.Encomienda)
                {
                    Encomienda encomienda = (Encomienda)listaVentas[i].servicio;
                    Console.WriteLine(encomienda.getNroEncomienda().ToString().PadRight(15) + encomienda.origen.PadRight(8) + encomienda.destino.PadRight(14) + listaVentas[i].tipocomprobante.ToString().PadRight(16) + listaVentas[i].tipopago.ToString().PadRight(12) + encomienda.monto.ToString().PadRight(6));
                }

            }


        }

    }
}
