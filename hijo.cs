using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f2
{
    
    public partial class hijo : Form
    {
        /// <summary>
        /// la capa de negocios
        /// </summary>
        businessLayer capaNegociosHijo = new businessLayer();

        public void agregarConexiones(int posicion, string valorA, string valorB)
        {
            capaNegociosHijo.agregarConexion(posicion, valorA, valorB);
        }

        /// <summary>
        /// recibe los parametros para poder iniciarse
        /// con los datos de conexion a la base da datos
        /// </summary>
        /// <param name="cadenaDeConexion"></param>
        public hijo(businessLayer capaNegociosPadre)
        {
            InitializeComponent();
            this.capaNegociosHijo = capaNegociosPadre;
        }

        private void hijo_Load(object sender, EventArgs e) { }



        private void btnListar_Click(object sender, EventArgs e)
        {
            ListadoTabla();
        }
        public void ListadoTabla()
        {
            dgCliente.DataSource = null;
            dgCliente.DataSource = capaNegociosHijo.SP_LISTAR_CLIENTES();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NOMBRE_CLIENTE = txtNombreCliente.Text;
            string APELLIDO_CLIENTE = txtApellidoCliente.Text;

            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                lblErrorNombre.Text = ("El campo Nombre no debe estar vacio");
                
            }
            else  if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                lblErrorApellido.Text = ("El campo Apellido no debe estar vacio");
            }
            else
            {
                lblErrorNombre.Text = ("");

                string datos = capaNegociosHijo.sp_insertar_cliente(NOMBRE_CLIENTE, APELLIDO_CLIENTE);
                MessageBox.Show("Los Datos fueron guardados");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCliente.Text))
            {
                lblErrorCod.Text = ("El campo codigo no debe estar vacio");
            }
            else
            {
                capaNegociosHijo.sp_eliminar_cliente(Convert.ToInt32(txtCodCliente.Text));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int CODIGO_CLIENTE = Convert.ToInt32(txtCodCliente.Text);
            string NOMBRE_CLIENTE = txtNombreCliente.Text;
            string APELLIDO_CLIENTE = txtApellidoCliente.Text;

            string datos = capaNegociosHijo.SP_UPDATE_CLIENTES(CODIGO_CLIENTE,NOMBRE_CLIENTE, APELLIDO_CLIENTE);

        }
    }
}