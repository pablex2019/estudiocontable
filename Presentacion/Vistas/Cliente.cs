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
    public partial class Cliente : Form
    {
        private int Codigo;
        private Controladores.MetodosGenericos _MetodoGenerico;
        private Controladores.Cliente _Cliente;

        public Cliente()
        {
            InitializeComponent();
            _MetodoGenerico = new Controladores.MetodosGenericos();
            _Cliente = new Controladores.Cliente("Clientes");
        }
        public List<string> Opciones()
        {
            List<string> lista = new List<string>();
            lista.Add("Seleccione");
            lista.Add("Razon Social");
            lista.Add("Cuit");
            lista.Add("Domicilio");
            lista.Add("Telefono");
            lista.Add("Representante");
            return lista;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            _MetodoGenerico.SoloNumeros(e);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _MetodoGenerico.Cancelar(null,this,null,2);
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
