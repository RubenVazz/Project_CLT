using System;
using System.Windows.Forms;

namespace f2
{
    public partial class frm_ventas : Form
    {
        businessLayer capaNegociosVentas = new businessLayer();
        public void agregarConexiones(int posicion, string valorA, string valorB)
        {
            capaNegociosVentas.agregarConexion(posicion, valorA, valorB);
        }
        public frm_ventas(businessLayer capaNegociosPadre)
        {
            InitializeComponent();
            this.capaNegociosVentas = capaNegociosPadre;

        }

        private void frm_ventas_Load(object sender, EventArgs e)
        {
            ListadoTabla();
        }

        private void btnListarProducto_Click(object sender, EventArgs e)
        {
            ListadoTabla();
            ListadoTablaClientes();
            ListadoTablaProductos();
        }

        public void ListadoTabla()
        {
            dgVentas.DataSource = null;
            dgVentas.DataSource = capaNegociosVentas.SP_LISTAR_VENTAS();
        }

        public void ListadoTablaClientes()
        {
            dgClientes.DataSource = null;
            dgClientes.DataSource = capaNegociosVentas.SP_LISTAR_CLIENTES();
        }
        public void ListadoTablaProductos()
        {
            dgProductos.DataSource = null;
            dgProductos.DataSource = capaNegociosVentas.SP_LISTAR_PRODUCTOS();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("El campo Cantidad no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PI_CANTIDAD = txtCantidad.Text;

            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo de Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CODIGO_PRODUCTO = Convert.ToInt32(txtProducto.Text);

            if (txtNombreProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PI_NOMBRE_PRODUCTO = txtNombreProducto.Text;

            if (txtCodCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo Cliente no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CODIGO_CLIENTE = Convert.ToInt32(txtCodCliente.Text);

            string datos = capaNegociosVentas.sp_insertar_ventas(PI_CANTIDAD, PI_CODIGO_PRODUCTO,
                                                        PI_NOMBRE_PRODUCTO, PI_CODIGO_CLIENTE);

            if (datos.Equals("OK"))
            {
                MessageBox.Show("El cliente fue eliminado");
            }
            else
            {
                MessageBox.Show(datos);
            }
            Limpiar();
            ListadoTabla();
        }




        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodVenta.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = capaNegociosVentas.sp_eliminar_ventas(Convert.ToInt32(txtCodVenta.Text));

            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("La venta fue eliminada");
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            
            Limpiar();
            ListadoTabla();

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("El campo Cantidad no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PI_CANTIDAD = txtCantidad.Text;
          
            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo de Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CODIGO_PRODUCTO = Convert.ToInt32(txtProducto.Text);
            
            if (txtNombreProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PI_NOMBRE_PRODUCTO = txtNombreProducto.Text;
            
            if (txtPrecioVenta.Text.Equals(""))
            {
                MessageBox.Show("El campo Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_PRECIO_VENTA = Convert.ToInt32(txtPrecioVenta.Text);

            if (txtCodCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo Cliente no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CODIGO_CLIENTE = Convert.ToInt32(txtCodCliente.Text);
            
            if (txtCodVenta.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo de Venta no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CODIGO_VENTA = Convert.ToInt32(txtCodVenta.Text);

            string mensaje = capaNegociosVentas.SP_UPDATE_VENTAS(PI_CANTIDAD, PI_CODIGO_PRODUCTO, PI_NOMBRE_PRODUCTO, PI_PRECIO_VENTA, PI_CODIGO_CLIENTE, PI_CODIGO_VENTA);


            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("El cliente fue actualizado");
            }
            else
            {
                MessageBox.Show(mensaje);
            }



            Limpiar();
            ListadoTabla();

        }

        public void Limpiar()
        {
            txtCantidad.Text = ("");
            txtCodCliente.Text = ("");
            txtCodVenta.Text = ("");
            txtNombreProducto.Text = ("");
            txtPrecioVenta.Text = ("");
            txtProducto.Text = ("");
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
            exportarDatos(dgVentas);
        }
    }
}
