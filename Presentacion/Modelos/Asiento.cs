using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class Asiento
    {
        public int idAsiento { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
        public float debe { get; set; }
        public float haber { get; set; }
        public int numeroAsiento { get; set; }
        public DateTime fecha { get; set; }
        public List<TipoCuenta> TiposCuentas {get;set;}
    }
}
