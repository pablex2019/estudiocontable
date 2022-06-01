using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas
{
    public partial class InicioSesion : Form
    {
        public Controladores.Usuario Usuario;

        public InicioSesion()
        {
            InitializeComponent();
            Usuario = new Controladores.Usuario("Usuarios");
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            Usuario.IniciarVista(txtUsuario, txtClave);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario.Existe(txtUsuario, txtClave);
        }
    }
}
