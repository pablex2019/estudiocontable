using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class InformeContable
    {
        public int idInformeContable { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
    }
}
