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
        public void Cancelar(Vistas.Empleado empleado,Vistas.Cliente cliente,Vistas.Contador contador, int i)
        {
            DialogResult respuesta = MessageBox.Show("¿ Esta seguro de cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (respuesta)
            {
                case DialogResult.Yes:
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
                        case 3://Contadores
                            contador.lblTituloListado.Show();
                            contador.lblFiltrar.Show();
                            contador.cboContadores.Show();
                            contador.dgvContadores.Show();
                            //Ocultar
                            //Rotulos
                            contador.lblListadoEmpleados.Hide();
                            contador.lblArea.Hide();
                            contador.lblPuesto.Hide();
                            //Campos
                            contador.txtArea.Hide();
                            contador.txtPuesto.Hide();
                            //Grilla
                            contador.dgvEmpleados.Hide();
                            //Botones
                            contador.btnGuardar.Hide();
                            contador.btnCancelar.Hide();
                            break;
                    }
                    break;
            }
        }
        public void Salir()
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (result)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }
        public void TituloYTexto(ComboBox ComboBox, Label titulo, TextBox texto,DataGridView dataGridView)
        {
            if (ComboBox.Text != "Seleccione")
            {
                titulo.Show();
                texto.Show();
                titulo.Text = "Ingrese " + ComboBox.Text;
                dataGridView.Show();
                dataGridView.ClearSelection();
                
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
            foreach (var i in control.Controls)
            {
                if (i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
            }
        }
        public void MensajeExistenciaElemento(string elemento)
        {
            MessageBox.Show("Ya existe el " + elemento, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool ElementoSeleccionado(int Codigo, int CantidadRegistro)
        {
            bool resultado = false;
            if(CantidadRegistro != 0)
            {
                switch (Codigo)
                {
                    case 0:
                        MessageBox.Show("Debe seleccionar un registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultado = true;
                        break;

                }
            }
            else
            {
                MessageBox.Show("No existe registros", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = true;
            }
            return resultado;
        }
        public DialogResult Eliminar(Form form)
        {
            DialogResult respuesta = MessageBox.Show("¿ Esta seguro de eliminar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return respuesta;
        }
        public bool ValidarCamposCompletados(Form form)
        {
            bool resultado = true;

            foreach (Control item in form.Controls)
            {
                try
                {
                    if (item is TextBox && item.Name != "txtDescripcion")
                    {
                        //Codigo comprobacion  de textbox
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("Hay campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            item.Focus();
                            return resultado = false;
                        }
                    }
                    else if (item is RichTextBox)
                    {
                        //codigo comprobacion de richtextbox
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("Hay campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            item.Focus();
                            return resultado = false;
                        }
                    }
                    /*else if (item is ComboBox)
                    {
                        if (item.Text == "Seleccione")
                        {
                            MessageBox.Show("Debe seleccionar un estado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            item.Focus();
                            return resultado = false;
                        }
                    }*/
                }
                catch { }
            }
            return resultado;
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsAllDigits(string s) 
        { 
            foreach (char c in s) 
            { 
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Solo puede ingresar numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } 
            } 
            return true;
        }
    }
}
