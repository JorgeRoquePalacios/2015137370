using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Venta
    {
        public Cliente cliente { set; get; }
        public Administrativo administrativo { set; get; }
        public TipoComprobante tipocomprobante { set; get; }
        public TipoPago tipopago { set; get; }
        public String fecha_registro { set; get; }
        public Servicio servicio { set; get; }
        public TipoServicio tiposervicio{set;get;}
        public double monto { set; get; }

        public Venta(Cliente cliente, Administrativo administrativo, TipoComprobante tipocomprobante, TipoPago tipopago, String fecha_registro, Servicio servicio,TipoServicio tiposervicio)
        {
            this.cliente = cliente;
            this.administrativo = administrativo;
            this.tipocomprobante = tipocomprobante;
            this.tipopago = tipopago;
            this.fecha_registro = fecha_registro;
            servicio.tiposervicio = tiposervicio;
            this.servicio = servicio;

        }

      

    }
}
