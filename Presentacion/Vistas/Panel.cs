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
    public partial class Panel : Form
    {
        private Controladores.MetodosGenericos MetodosGenericos;

        public Panel()
        {
            InitializeComponent();
            MetodosGenericos = new Controladores.MetodosGenericos();
        }

        private void mnuEmpleados_Click(object sender, EventArgs e)
        {
            Vistas.Empleado indice = new Empleado();
            indice.MdiParent = this;
            indice.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            MetodosGenericos.Salir();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            Vistas.Cliente indiceCliente = new Cliente();
            indiceCliente.MdiParent = this;
            indiceCliente.Show();
        }

        private void mnuContadores_Click(object sender, EventArgs e)
        {
            new Vistas.Contador().Show();
        }

        private void mnuSecretarias_Click(object sender, EventArgs e)
        {

        }
    }
}
