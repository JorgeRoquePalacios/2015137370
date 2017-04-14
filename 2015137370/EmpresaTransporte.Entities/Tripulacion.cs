using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Tripulacion
    {
        public TipoTripulacion tipotripulacion { set; get; }
        public String dni { set; get; }
        public String nombre { set; get; }
        public String ap_paterno { set; get; }
        public String ap_materno { set; get; }
        public String fec_nacimiento { set; get; }
        public String licencia { set; get; }
        public String fec_ingreso { set; get; }
        public TipoEmpleado tipoempleado { set; get; }
    }
}
