using System;
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

        private void hijo_Load(object sender, EventArgs e)
        {
            ListadoTabla();
        }



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
            
            if (txtNombreCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCliente.Focus();
                return;
            }
            string NOMBRE_CLIENTE = txtNombreCliente.Text;
            if (txtApellidoCliente.Text.Equals(""))
            {                
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoCliente.Focus();
                return;
            }
            string APELLIDO_CLIENTE = txtApellidoCliente.Text;
            string datos = capaNegociosHijo.sp_insertar_cliente(NOMBRE_CLIENTE, APELLIDO_CLIENTE);
          
            if (datos.Equals("OK"))
            {
                MessageBox.Show("Los Datos Fueron Guardados");
            }
            else
            {
                MessageBox.Show(datos);
            }
            limpiar();
            ListadoTabla();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = capaNegociosHijo.sp_eliminar_cliente(Convert.ToInt32(txtCodCliente.Text));

            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("El cliente fue eliminado");
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            limpiar();
            ListadoTabla();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CODIGO_CLIENTE = Convert.ToInt32(txtCodCliente.Text);
            if (txtNombreCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Nombre no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCliente.Focus();
                return;
            }
            string NOMBRE_CLIENTE = txtNombreCliente.Text;
            if (txtApellidoCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Apellido no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoCliente.Focus();
                return;
            }
            string APELLIDO_CLIENTE = txtApellidoCliente.Text;

            string mensaje = capaNegociosHijo.SP_UPDATE_CLIENTES(CODIGO_CLIENTE, NOMBRE_CLIENTE, APELLIDO_CLIENTE);

            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("El cliente fue actualizado");
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            
            limpiar();
            ListadoTabla();

        }

        public void limpiar()
        {
            txtApellidoCliente.Text = ("");
            txtCodCliente.Text = ("");
            txtNombreCliente.Text = ("");
        }

        public void exportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();


            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            exportarExcel.Visible = true;
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportarDatos(dgCliente);
        }
        ErrorProvider errorP0 = new ErrorProvider();
        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
          bool valida =  Validaciones.soloNUmeros(e);
            if (!valida)
            {
                errorP0.SetError(txtCodCliente, "Solo Numeros");
            }
            else
            {
                errorP0.Clear();
            }
        }
    }
}
