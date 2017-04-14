using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class SimularVentas
    {


        public List<Venta> getlistaVentas()
        {

            Cliente cli1 = new Cliente("76412322", "Jorge", "Roque", "Palacios", "Av. Las Flores de Primavera 221", "923122122");
            Cliente cli2 = new Cliente("70542132", "Camila", "Arango", "Rojas", "Av. Nicolas Ayllon 1233 San Luis", "963811212");
            Cliente cli3 = new Cliente("10231232", "Martin", "Sosa", "De la Cruz", "Av. Circunvalacion 122 San Luis", "998724126");
            Bus bus = new Bus(1010,"B52JU2",60);

            Administrativo administrador = new Administrativo("11231212","Esteban","Gomero","",TipoEmpleado.administrativo);
            LugarViaje lugar = new LugarViaje("Terminal Plaza Norte","Av. Gerardo Unger 1911 int 44",TipoLugar.Terminal,"3767047");

            var enc1 = new Encomienda(102912, "Lima", "Cajamarca", lugar, 105, "Caja con Viveres");
            var enc2 = new Encomienda(102913, "Lima", "Tingo Maria", lugar, 95, "Bicicleta");
            var enc3 = new Encomienda(102914, "Lima", "Apurimac", lugar, 220, "Televisor 402\"");

            var tr1 = new Transporte(1055, "Lima", "Ayacucho", TipoViaje.VIP, bus, lugar, cli1, "2017-04-10", 100);
            var tr2 = new Transporte(1056, "Lima", "Cuzco", TipoViaje.Normal, bus, lugar, cli2, "2017-04-11", 120);
            var tr3 = new Transporte(1057, "Lima", "Arequipa", TipoViaje.VIP, bus, lugar, cli3, "2017-04-12", 110);

            //var encomienda2 = new Encomienda();
            //var transporte1 = new Transporte();
            //var transporte2 = new Transporte();
            //var transporte3 = new Transporte();

            List<Venta> listaVentas = new List<Venta>();

            Venta venta1 = new Venta(cli1, administrador, TipoComprobante.Boleta, TipoPago.Contado, "2017-04-13", enc1,TipoServicio.Encomienda);
            Venta venta2 = new Venta(cli2, administrador, TipoComprobante.Factura, TipoPago.Credito, "2017-04-13", enc2, TipoServicio.Encomienda);
            Venta venta3 = new Venta(cli3, administrador, TipoComprobante.Boleta, TipoPago.Contado, "2017-04-13", tr1, TipoServicio.Transporte);
            Venta venta4 = new Venta(cli1, administrador, TipoComprobante.Factura, TipoPago.Credito, "2017-04-13", tr2, TipoServicio.Transporte);
            Venta venta5 = new Venta(cli2, administrador, TipoComprobante.Factura, TipoPago.Credito, "2017-04-13", tr3, TipoServicio.Transporte);

            
            listaVentas.Add(venta1);
            listaVentas.Add(venta2);
            listaVentas.Add(venta3);
            listaVentas.Add(venta4);
            listaVentas.Add(venta5);

            return listaVentas;
        }
    }
}
