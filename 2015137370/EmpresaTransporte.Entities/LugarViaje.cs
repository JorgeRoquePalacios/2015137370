using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class LugarViaje
    {
        private String nombre;
        private String direccion;
        private TipoLugar tipolugar;
        private String telefono;

        public LugarViaje(String nombre, String direccion, TipoLugar tipolugar, String telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.tipolugar = tipolugar;
            this.telefono = telefono;
        }
    }
}
