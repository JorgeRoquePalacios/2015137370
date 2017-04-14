using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Administrativo
    {
        private String dni;
        private String nombre;
        private String ap_paterno;
        private String ap_materno;
        private String fec_ingreso;
        private TipoEmpleado tipoempleado;


        public Administrativo(String dni, String nombre, String ap_paterno, String ap_materno, TipoEmpleado tipoempleado)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.ap_materno = ap_materno;
            this.ap_paterno = ap_paterno;
            this.tipoempleado = tipoempleado;
        }

    }
}
