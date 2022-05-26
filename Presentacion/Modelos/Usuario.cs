using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelos
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public Empleado Empleado { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
