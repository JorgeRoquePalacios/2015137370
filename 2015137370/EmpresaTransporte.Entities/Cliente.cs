using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Cliente
    {
        public String dni { set; get; }
        public String nombre { set; get; }
        public String ap_paterno { set; get; }
        public String ap_materno { set; get; }
        public String direccion { set; get; }
        public String telefono { set; get; }

        public String getnombre_completo()
        {
            return this.nombre+" "+this.ap_paterno+" "+this.ap_materno; 
        }

        public String getnombre()
        {
            return this.nombre + " " + this.ap_paterno;
        }

        public Cliente()
        {

        }

        public Cliente(String dni, String nombre, String ap_paterno, String ap_materno, String direccion, String telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.ap_paterno = ap_paterno;
            this.ap_materno=ap_materno;
            this.direccion=direccion;
            this.telefono=telefono;
        }


    }
}
