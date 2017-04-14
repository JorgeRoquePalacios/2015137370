using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Bus
    {
        private int nroBus;
        private String placa;
        private int nroAsientos;

        public Bus(int nroBus, String placa, int nroAsientos)
        {
            this.nroBus = nroBus;
            this.placa = placa;
            this.nroAsientos = nroAsientos;
        }
    }
}
