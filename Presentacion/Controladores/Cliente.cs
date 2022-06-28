using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controladores
{
    public class Cliente
    {
        private string Archivo { get; set; }
        private Datos.Acceso Acceso { get; set; }
        private List<Modelos.Cliente> Clientes { get; set; }
        private string DatosClientes;
        private Controladores.MetodosGenericos MetodosGenericos { get; set; }

        public Cliente(string _Archivo)
        {
            this.Archivo = _Archivo;
            this.Acceso = new Datos.Acceso(this.Archivo);
            MetodosGenericos = new MetodosGenericos();
        }
        public void Leer()
        {
            this.DatosClientes = this.Acceso.Leer();
            this.Clientes = this.DatosClientes?.Length > 0 ? JsonConvert.DeserializeObject<List<Modelos.Cliente>>(this.DatosClientes) : new List<Modelos.Cliente>();
        }
        public void Guardar()
        {
            //Convierto todos los datos a string
            this.DatosClientes = JsonConvert.SerializeObject(this.Clientes);
            this.Acceso.Guardar(this.DatosClientes);
        }
        public List<Modelos.Cliente> Listado()
        {
            Leer();
            return this.Clientes.OrderBy(x => x.idCliente).ToList();
        }
        public bool Existe(string razonSocial, string cuit)
        {
            Leer();
            return this.Clientes.Any(x => x.razonSocial == razonSocial && x.cuit == cuit);
        }
        public Modelos.Cliente ObtenerCliente(int codigo)
        {
            Leer();
            return this.Clientes.Where(x => x.idCliente == codigo).FirstOrDefault();
        }
        public int ObtenerUltimoCodigo()
        {
            Leer();
            return this.Clientes.Count == 0 ? 1 : Clientes.Max(x => x.idCliente) + 1;
        }
        public List<Modelos.Cliente> BuscarCliente(string texto, string opcion)
        {
            Leer();
            List<Modelos.Cliente> clientes = new List<Modelos.Cliente>();
            switch (opcion)
            {
                case "Codigo":
                    clientes = Clientes.Where(x => x.idCliente == Convert.ToInt32(texto)).ToList();
                    break;
                case "Razon Social":
                    clientes = Clientes.Where(x => x.razonSocial.Contains(texto)).ToList();
                    break;
                case "Cuit":
                    clientes = Clientes.Where(x => x.cuit.Contains(texto)).ToList();
                    break;
                case "Domicilio":
                    clientes = Clientes.Where(x => x.domicilio.Contains(texto)).ToList();
                    break;
                case "Telefono":
                    clientes = Clientes.Where(x => x.telefono == Convert.ToInt32(texto)).ToList();
                    break;
                case "Representante":
                    clientes = Clientes.Where(x => x.representante.Contains(texto)).ToList();
                    break;
                default:
                    clientes = Clientes.ToList();
                    break;
            }
            return clientes;
        }
        public void ABM(int operacion, Vistas.Cliente gestionCliente, int codigo, DataGridView grillaCliente)
        {
            Leer();
            Modelos.Cliente cliente = new Modelos.Cliente();
            var _cliente = ObtenerCliente(codigo);
            switch (operacion)
            {
                /* case 1://Alta
                     if (MetodosGenericos.ValidarCamposCompletados(gestionCliente))
                     {
                         if (Existe(gestionCliente.txtRazonSocial.Text, gestionCliente.txtCuit.Text) != true)
                         {
                             cliente.idCliente = Clientes.Count == 0 ? 1 : ObtenerUltimoCodigo();
                             cliente.razonSocial = gestionCliente.txtRazonSocial.Text;
                             cliente.cuit = gestionCliente.txtCuit.Text;
                             cliente.domicilio = gestionCliente.txtDomicilio.Text;
                             cliente.telefono= Convert.ToInt32(gestionCliente.txtTelefono.Text);
                             cliente.representante = gestionCliente.txtRepresentante.Text;
                             this.Clientes.Add(cliente);
                             Guardar();
                             MetodosGenericos.ABMElementos("Cliente", 1);
                             MetodosGenericos.LimpiarCampos(gestionCliente);
                             grillaCliente.DataSource = Listado();
                             gestionCliente.txtCodigo.Text = ObtenerUltimoCodigo().ToString();
                             grillaCliente.ClearSelection();
                         }
                         else
                         {
                             MetodosGenericos.MensajeExistenciaElemento("Empleado");
                         }
                     }
                     break;
                 case 2://Modificiacion
                     if (MetodosGenericos.ValidarCamposCompletados(gestionCliente))
                     {
                         if (Existe(gestionCliente.txtRazonSocial.Text, gestionCliente.txtCuit.Text) != true)
                         {
                             var _clienteE = ObtenerCliente(codigo);
                             _clienteE.razonSocial = gestionCliente.txtRazonSocial.Text;
                             _clienteE.cuit = gestionCliente.txtCuit.Text;
                             _clienteE.domicilio = gestionCliente.txtDomicilio.Text;
                             _clienteE.telefono = Convert.ToInt32(gestionCliente.txtTelefono.Text);
                             _clienteE.representante = gestionCliente.txtRepresentante.Text;
                             Guardar();
                             MetodosGenericos.ABMElementos("Empleado", 2);
                             gestionCliente.lblTituloListado.Show();
                             gestionCliente.lblFiltrar.Show();
                             gestionCliente.cboClientes.Show();
                             //Ocultar
                             //Rotulos
                             gestionCliente.lblCodigo.Hide();
                             gestionCliente.lblRazonSocial.Hide();
                             gestionCliente.lblCuit.Hide();
                             gestionCliente.lblDomicilio.Hide();
                             gestionCliente.lblTelefono.Hide();
                             gestionCliente.lblRepresentante.Hide();
                             //Campos
                             gestionCliente.txtCodigo.Hide();
                             gestionCliente.txtRazonSocial.Hide();
                             gestionCliente.txtCuit.Hide();
                             gestionCliente.txtDomicilio.Hide();
                             gestionCliente.txtTelefono.Hide();
                             gestionCliente.txtRepresentante.Hide();
                             //Botones
                             gestionCliente.btnGuardar.Hide();
                             gestionCliente.btnCancelar.Hide();
                             grillaCliente.DataSource = Listado();
                             grillaCliente.ClearSelection();
                             gestionCliente.dgvClientes.Show();
                         }
                         else
                         {
                             MetodosGenericos.MensajeExistenciaElemento("Empleado");
                         }
                     }
                     break;
                 case 3://Baja
                     this.Clientes.Remove(_cliente);
                     Guardar();
                     MetodosGenericos.ABMElementos("Empleado", 3);
                     grillaCliente.DataSource = Listado();
                     grillaCliente.ClearSelection();
                     break;
            }*/
            }
        }
    }
}
