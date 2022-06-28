using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controladores
{
    public class Contador
    {
        private string Archivo { get; set; }
        private Datos.Acceso Acceso { get; set; }
        private List<Modelos.Contador> Contadores { get; set; }
        private string DatosContadores;
        private Controladores.MetodosGenericos MetodosGenericos { get; set; }

        public Contador(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.Acceso = new Datos.Acceso(this.Archivo);
            MetodosGenericos = new MetodosGenericos();
        }
        public void Leer()
        {
            this.DatosContadores = this.Acceso.Leer();
            this.Contadores = this.DatosContadores?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Contador>>(this.DatosContadores) : new List<Modelos.Contador>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosContadores = JsonConvert.SerializeObject(this.DatosContadores);
            this.Acceso.Guardar(this.DatosContadores);
        }
        public List<Modelos.Contador> Listado()
        {
            Leer();
            return this.Contadores.OrderBy(x => x.idContador).ToList();
        }
        public void Personalizar(DataGridView dataGridView)
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Width = 125;
            dataGridView.Columns[2].Width = 225;
        }
    }
}
