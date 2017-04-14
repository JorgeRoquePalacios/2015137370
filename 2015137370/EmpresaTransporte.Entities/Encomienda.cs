using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Encomienda : Servicio
    {

        public int nroEncomienda { set; get; }
        public String origen { set; get; }
        public String destino { set; get; }
        public LugarViaje lugarviaje { set; get; }
        public double monto { set; get; }
        public String descripcion { set; get; }
        public TipoServicio tiposervicio { set; get; }
        
        

        public Encomienda(int nroEncomienda, String origen, String destino, LugarViaje lugarviaje, double monto, String descripcion)
        {
            this.nroEncomienda = nroEncomienda;
            this.origen = origen;
            this.destino = destino;
            this.lugarviaje = lugarviaje;
            this.monto = monto;
            this.descripcion = descripcion;
        }

        

        public int getNroEncomienda()
        {
            return nroEncomienda;
        }

        public TipoServicio getTipoServicio { get { return tiposervicio;} }
    }
}
