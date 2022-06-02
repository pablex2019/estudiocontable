using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controladores
{
    public class MetodosGenericos
    {
        public void Cancelar(Vistas.Empleado empleado,int i)
        {
            DialogResult respuesta = MessageBox.Show("¿ Esta seguro de cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (respuesta)
            {
                case DialogResult.Yes :
                    switch (i)
                    {
                        case 1://Empleado
                            empleado.lblTituloListado.Show();
                            empleado.lblFiltrar.Show();
                            empleado.cboEmpleados.Show();
                            empleado.dgvEmpleados.Show();
                            //Ocultar
                            //Rotulos
                            empleado.lblCodigo.Hide();
                            empleado.lblNombre.Hide();
                            empleado.lblApellido.Hide();
                            empleado.lblDni.Hide();
                            empleado.lblDomicilio.Hide();
                            empleado.lblTelefono.Hide();
                            //Campos
                            empleado.txtCodigo.Hide();
                            empleado.txtNombre.Hide();
                            empleado.txtApellido.Hide();
                            empleado.txtDni.Hide();
                            empleado.txtDomicilio.Hide();
                            empleado.txtTelefono.Hide();
                            //Botones
                            empleado.btnGuardar.Hide();
                            empleado.btnCancelar.Hide();
                            break;
                    }
                    break;
            }
        }
        public void TituloYTexto(ComboBox ComboBox, Label titulo,TextBox texto)
        {
            if (ComboBox.Text != "Seleccione")
            {
                titulo.Show();
                texto.Show();
                titulo.Text = "Ingrese " + ComboBox.Text;
            }
            else
            {
                titulo.Hide();
                texto.Hide();
            }
        }
        public void ABMElementos(string elemento, int operacion)
        {
            switch (operacion)
            {
                case 1:
                    MessageBox.Show(elemento + " Agregado/a", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(elemento + " Editado/a", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show(elemento + " Eliminado/a", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        public void LimpiarCampos(Control control)
        {
            foreach(var i in control.Controls)
            {
                if( i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
            }
        }
        public void MensajeExistenciaElemento(string elemento)
        {
            MessageBox.Show("Ya existe el " + elemento, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool ElementoSeleccionado(int Codigo)
        {
            bool resultado = false;
            switch(Codigo)
            {
                case 0:
                    MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                    
            }
            return resultado;
        }
    }
}
