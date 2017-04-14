using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Transporte : Servicio
    {
        private String origen;
        private String destino;
        private TipoViaje tipoviaje;
        private String fecha;
        private int nroBoleto;
        private Bus bus;
        private LugarViaje lugarviaje;
        private Cliente cliente;
        public TipoServicio tiposervicio { set; get; }
        private double monto;

        public Transporte(int nroBoleto,String origen, String destino, TipoViaje tipoviaje, Bus bus, LugarViaje lugarviaje, Cliente cliente, String fecha, double monto)
        {
            this.nroBoleto = nroBoleto;
            this.origen = origen;
            this.destino = destino;
            this.tipoviaje = tipoviaje;
            this.fecha = fecha;
            this.bus = bus;
            this.lugarviaje = lugarviaje;
            this.cliente = cliente;
            this.monto = monto;

        }

        public int getNroBoleto()
        {
            return nroBoleto;
        }
        
        public TipoServicio getTipoServicio { get { return tiposervicio; } }

        public TipoViaje getTipoViaje()
        {
            return tipoviaje;
        }

        public Cliente getCliente()
        {
            return cliente;
        }

        public String getOrigen()
        {
            return origen;
        }

        public String getDestino()
        {
            return destino;
        }

        public double getMonto()
        {
            return monto;
        }

    }
}
