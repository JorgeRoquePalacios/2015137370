﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public interface Empleado
    {
         TipoEmpleado tipoempleado { set; get; }
    }
}