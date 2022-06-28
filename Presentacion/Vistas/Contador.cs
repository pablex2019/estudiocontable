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
    public partial class Contador : Form
    {
        private int IdContador;
        private Controladores.MetodosGenericos _MetodoGenerico;
        private Controladores.Contador _Contador;

        public Contador()
        {
            InitializeComponent();
            _MetodoGenerico = new Controladores.MetodosGenericos();
            _Contador = new Controladores.Contador("Contadores");
        }
        public List<string> Opciones()
        {
            List<string> lista = new List<string>();
            lista.Add("Seleccione");
            lista.Add("Area");
            lista.Add("Puesto");
            return lista;
        }
        private void Contador_Load(object sender, EventArgs e)
        {
            cboContadores.DataSource = Opciones();
            lblDescripcion.Hide();
            txtDescripcion.Hide();
            txtArea.Hide();
            txtPuesto.Hide();
            lblArea.Hide();
            lblPuesto.Hide();
            lblListadoEmpleados.Hide();
            dgvEmpleados.Hide();
            btnGuardar.Hide();
            btnCancelar.Hide();
            dgvContadores.DataSource = _Contador.Listado();
            _Contador.Personalizar(dgvContadores);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Rotulo y Campos 
            //Revelados
            lblArea.Show();
            lblPuesto.Show();
            txtArea.Show();
            txtPuesto.Show();
            lblListadoEmpleados.Show();
            dgvEmpleados.Show();
            btnGuardar.Show();
            btnCancelar.Show();
            //Ocultos
            lblTituloListado.Hide();
            lblFiltrar.Hide();
            lblDescripcion.Hide();
            txtDescripcion.Hide();
            cboContadores.Hide();
            dgvContadores.Hide();
        }

        private void cboContadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvContadores.DataSource = _Contador.Listado();
            _MetodoGenerico.TituloYTexto(cboContadores, lblDescripcion, txtDescripcion, dgvContadores);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _MetodoGenerico.Cancelar(null, null,this, 3);
        }
    }
}
