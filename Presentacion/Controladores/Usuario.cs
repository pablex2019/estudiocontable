using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controladores
{
    public class Usuario
    {
        private string Archivo { get; set; }
        private Datos.Acceso Acceso { get; set; }
        private List<Modelos.Usuario> Usuarios { get; set; }
        private string DatosUsuarios;
        
        public Usuario (string _Archivo)
        {
            this.Archivo = _Archivo;
            this.Acceso = new Datos.Acceso(this.Archivo);
        }
        public void Leer()
        {
            this.DatosUsuarios = this.Acceso.Leer();
            this.Usuarios = this.DatosUsuarios?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Usuario>>(this.DatosUsuarios) : new List<Modelos.Usuario>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosUsuarios = JsonConvert.SerializeObject(this.Usuarios);
            this.Usuarios = this.DatosUsuarios?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Usuario>>(this.DatosUsuarios) : new List<Modelos.Usuario>();
        }
        public void IniciarVista(TextBox usuario, TextBox clave)
        {
            usuario.Text = clave.Text = string.Empty;
        }
        public void Existe(TextBox usuario, TextBox clave)
        {
            Leer();
            if (this.Usuarios.Any(x => x.NombreUsuario == usuario.Text && x.Contraseña == clave.Text))
            {
                new Vistas.Panel().Show();
            }
        }
    }
}
