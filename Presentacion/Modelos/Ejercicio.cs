using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class Ejercicio
    {
        public int idEjercicio { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int numeroEjercicio { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Contador> Contadores { get; set; }
    }
}
