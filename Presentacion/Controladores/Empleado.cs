using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controladores
{
    public class Empleado
    {
        private string Archivo { get; set; }
        private Datos.Acceso Acceso { get; set; }
        private List<Modelos.Empleado> Empleados { get; set; }
        private string DatosEmpleados;
        private Controladores.MetodosGenericos MetodosGenericos { get; set; }

        public Empleado(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.Acceso = new Datos.Acceso(this.Archivo);
            MetodosGenericos = new MetodosGenericos();
        }
        public void Leer()
        {
            this.DatosEmpleados = this.Acceso.Leer();
            this.Empleados = this.DatosEmpleados?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Empleado>>(this.DatosEmpleados) : new List<Modelos.Empleado>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosEmpleados = JsonConvert.SerializeObject(this.Empleados);
            this.Acceso.Guardar(this.DatosEmpleados);
        }
        public List<Modelos.Empleado> Listado()
        {
            Leer();
            return this.Empleados.OrderBy(x => x.Nombre).ToList();
        }
        public bool Existe(string nombre, string apellido,int operacion,int dni)
        {
            Leer();
            return this.Empleados.Any(x => x.Nombre == nombre && x.Apellido == apellido);
        }
        public Modelos.Empleado ObtenerEmpleado(int codigo)
        {
            Leer();
            return this.Empleados.Where(x => x.Codigo == codigo).FirstOrDefault();
        }
        public int ObtenerUltimoCodigo()
        {
            Leer();
            return this.Empleados.Count == 0 ? 1 : Empleados.Max(x => x.Codigo) + 1;
        }
        public void ABM(int operacion, Vistas.Empleado gestionEmpleado, int codigo, DataGridView grillaEmpleado)
        {
            Leer();
            Modelos.Empleado empleado = new Modelos.Empleado();
            var _empleado = ObtenerEmpleado(codigo);
            switch (operacion)
            {
                case 1://Alta
                    if (Existe(gestionEmpleado.txtNombre.Text, gestionEmpleado.txtApellido.Text,1,0) != true)
                    {
                        empleado.Codigo = Empleados.Count == 0 ? 1 : ObtenerUltimoCodigo();
                        empleado.Nombre = gestionEmpleado.txtNombre.Text;
                        empleado.Apellido = gestionEmpleado.txtApellido.Text;
                        empleado.Dni = Convert.ToInt32(gestionEmpleado.txtDni.Text);
                        empleado.Domicilio = gestionEmpleado.txtDomicilio.Text;
                        empleado.Telefono = gestionEmpleado.txtTelefono.Text;
                        this.Empleados.Add(empleado);
                        Guardar();
                        MetodosGenericos.ABMElementos("Empleado", 1);
                        MetodosGenericos.LimpiarCampos(gestionEmpleado);
                        grillaEmpleado.DataSource = Listado();
                        gestionEmpleado.txtCodigo.Text = ObtenerUltimoCodigo().ToString();
                        grillaEmpleado.ClearSelection();
                    }
                    else
                    {
                        MetodosGenericos.MensajeExistenciaElemento("Empleado");
                    }
                    break;
                case 2://Modificiacion
                    if (Existe(gestionEmpleado.txtNombre.Text, gestionEmpleado.txtApellido.Text, 1,0) != true)
                    {
                            var _empleadoE = ObtenerEmpleado(codigo);
                            _empleadoE.Nombre = gestionEmpleado.txtNombre.Text;
                            _empleadoE.Apellido = gestionEmpleado.txtApellido.Text;
                            _empleadoE.Dni = Convert.ToInt32(gestionEmpleado.txtDni.Text);
                            _empleadoE.Domicilio = gestionEmpleado.txtDomicilio.Text;
                            _empleadoE.Telefono = gestionEmpleado.txtTelefono.Text;
                            Guardar();
                            MetodosGenericos.ABMElementos("Empleado", 2);
                            gestionEmpleado.lblTituloListado.Show();
                            gestionEmpleado.lblFiltrar.Show();
                            gestionEmpleado.cboEmpleados.Show();
                            //Ocultar
                            //Rotulos
                            gestionEmpleado.lblCodigo.Hide();
                            gestionEmpleado.lblNombre.Hide();
                            gestionEmpleado.lblApellido.Hide();
                            gestionEmpleado.lblDni.Hide();
                            gestionEmpleado.lblDomicilio.Hide();
                            gestionEmpleado.lblTelefono.Hide();
                            //Campos
                            gestionEmpleado.txtCodigo.Hide();
                            gestionEmpleado.txtNombre.Hide();
                            gestionEmpleado.txtApellido.Hide();
                            gestionEmpleado.txtDni.Hide();
                            gestionEmpleado.txtDomicilio.Hide();
                            gestionEmpleado.txtTelefono.Hide();
                            //Botones
                            gestionEmpleado.btnGuardar.Hide();
                            gestionEmpleado.btnCancelar.Hide();
                            grillaEmpleado.DataSource = Listado();
                            grillaEmpleado.ClearSelection();
                            gestionEmpleado.dgvEmpleados.Show();
                    }
                    else
                    {
                            MetodosGenericos.MensajeExistenciaElemento("Empleado");
                    }
                    break;
                case 3://Baja
                    this.Empleados.Remove(_empleado);
                    Guardar();
                    MetodosGenericos.ABMElementos("Empleado", 3);
                    grillaEmpleado.DataSource = Listado();
                    grillaEmpleado.ClearSelection();
                    break;
            }
        }
    }
}
