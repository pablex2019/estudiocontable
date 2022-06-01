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
        public Panel()
        {
            InitializeComponent();
        }

        private void mnuEmpleados_Click(object sender, EventArgs e)
        {
            Vistas.Empleado indice = new Empleado();
            indice.MdiParent = this;
            indice.Show();
        }
    }
}
