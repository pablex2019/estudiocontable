using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Controladores
{
    public class Empleado
    {
        private string Archivo { get; set; }
        private Datos.Acceso Acceso { get; set; }
        private List<Modelos.Empleado> Empleados { get; set; }
        private string DatosEmpleados;

        public Empleado(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.Acceso = new Datos.Acceso(this.Archivo);
        }
        public void Leer()
        {
            this.DatosEmpleados = this.Acceso.Leer();
            this.Empleados = this.DatosEmpleados?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Empleado>>(this.DatosEmpleados) : new List<Modelos.Empleado>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosEmpleados = JsonConvert.SerializeObject(this.Empleados);
            this.Empleados = this.DatosEmpleados?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Empleado>>(this.DatosEmpleados) : new List<Modelos.Empleado>();
        }
        public List<Modelos.Empleado> Listado()
        {
            Leer();
            return this.Empleados.OrderBy(x => x.Nombre).ToList();
        }
    }
}
