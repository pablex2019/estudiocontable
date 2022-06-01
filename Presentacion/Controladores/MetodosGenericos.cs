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
            var respuesta = MessageBox.Show("¿ Esta seguro de cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            switch (respuesta)
            {
                case DialogResult.OK :
                    switch (i)
                    {
                        case 1://Empleado
                            
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
    }
}
