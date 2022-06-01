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
    public partial class Empleado : Form
    {
        private Controladores.MetodosGenericos _MetodoGenerico;
        private Controladores.Empleado _Empleado;

        public Empleado()
        {
            InitializeComponent();
            _MetodoGenerico = new Controladores.MetodosGenericos();
            _Empleado = new Controladores.Empleado("Empleados");
        }
        public List<string> Opciones()
        {
            List<string> lista = new List<string>();
            lista.Add("Seleccione");
            lista.Add("Codigo");
            lista.Add("Nombre");
            lista.Add("Apellido");
            lista.Add("Dni");
            lista.Add("Domicilio");
            lista.Add("Telefono");
            return lista;
        }
        private void Index_Load(object sender, EventArgs e)
        {
            lblDescripcion.Hide();
            txtDescripcion.Hide();
            ///Oculto
            //Titulos
            lblCodigo.Hide();
            lblNombre.Hide();
            lblApellido.Hide();
            lblDni.Hide();
            lblDomicilio.Hide();
            lblTelefono.Hide();
            //Campos
            txtCodigo.Hide();
            txtNombre.Hide();
            txtApellido.Hide();
            txtDni.Hide();
            txtDomicilio.Hide();
            txtTelefono.Hide();
            //Botones
            btnGuardar.Hide();
            btnCancelar.Hide();
            ///
            cboEmpleados.DataSource = Opciones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Rotulo y Campos 
            //Ocultos
            lblTituloListado.Hide();
            lblFiltrar.Hide();
            lblDescripcion.Hide();
            txtDescripcion.Hide();
            dgvEmpleados.Hide();
            cboEmpleados.Hide();
            //Revelados
            lblCodigo.Show();
            txtCodigo.Show();
            lblNombre.Show();
            txtNombre.Show();
            lblApellido.Show();
            txtApellido.Show();
            lblDni.Show();
            txtDni.Show();
            lblDomicilio.Show();
            txtDomicilio.Show();
            lblTelefono.Show();
            txtTelefono.Show();
            btnCancelar.Show();
            btnGuardar.Show();
            //
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Rotulo y Campos 
            //Ocultos
            lblTituloListado.Hide();
            lblFiltrar.Hide();
            lblDescripcion.Hide();
            txtDescripcion.Hide();
            dgvEmpleados.Hide();
            cboEmpleados.Hide();
            //Revelados
            lblCodigo.Show();
            txtCodigo.Show();
            lblNombre.Show();
            txtNombre.Show();
            lblApellido.Show();
            txtApellido.Show();
            lblDni.Show();
            txtDni.Show();
            lblDomicilio.Show();
            txtDomicilio.Show();
            lblTelefono.Show();
            txtTelefono.Show();
            btnCancelar.Show();
            btnGuardar.Show();
            //
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            _MetodoGenerico.TituloYTexto(cboEmpleados,lblDescripcion,txtDescripcion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _MetodoGenerico.Cancelar(this,1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
