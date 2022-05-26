using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class Contador
    {
        public int idSecretaria { get; set; }
        public string Area { get; set; }
        public string Puesto { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
