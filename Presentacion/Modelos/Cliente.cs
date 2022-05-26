using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string razonSocial { get; set; }
        public string cuit { get; set; }
        public string domicilio { get; set; }
        public int telefono { get; set; }
        public string representante { get; set; }
    }
}
