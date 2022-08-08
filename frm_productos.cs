using System;
using System.Windows.Forms;

namespace f2
{
    public partial class frm_productos : Form
    {
        businessLayer capaNegociosProductos = new businessLayer();
        public void agregarConexiones(int posicion, string valorA, string valorB)
        {
            capaNegociosProductos.agregarConexion(posicion, valorA, valorB);
        }

        public frm_productos(businessLayer capaNegociosPadre)
        {
            InitializeComponent();
            this.capaNegociosProductos = capaNegociosPadre;

        }

        private void frm_productos_Load(object sender, EventArgs e)
        {
            ListadoTabla();
        }

        private void btnListarProducto_Click(object sender, EventArgs e)
        {
            ListadoTabla();
        }
        public void ListadoTabla()
        {
            dgProducto.DataSource = null;
            dgProducto.DataSource = capaNegociosProductos.SP_LISTAR_PRODUCTOS();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if (txtPrecioProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Precio no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float PRECIO = float.Parse(txtPrecioProducto.Text);

            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PRODUCTO = txtProducto.Text;

            if (txtCantidadProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Cantidad no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string CANTIDAD = txtCantidadProducto.Text;

            string datos = capaNegociosProductos.sp_insertar_producto(PRODUCTO, PRECIO, CANTIDAD);
            Limpiar();
            ListadoTabla();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            if (txtCodProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = capaNegociosProductos.sp_eliminar_producto(Convert.ToInt32(txtCodProducto.Text));

            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("El producto fue eliminado");
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

            if (txtCodProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CODIGO_PRODUCTO = Convert.ToInt32(txtCodProducto.Text);
            if (txtPrecioProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Precio no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float PRECIO = float.Parse(txtPrecioProducto.Text);

            if (txtCantidadProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Cantidad no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string CANTIDAD = txtCantidadProducto.Text;
            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Producto no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PRODUCTO = txtProducto.Text;

            string mensaje = capaNegociosProductos.SP_UPDATE_PRODUCTOS(PRODUCTO, PRECIO, CANTIDAD, CODIGO_PRODUCTO);

            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("El producto fue modificado");
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            //string datos = capaNegociosProductos.SP_UPDATE_PRODUCTOS(PRODUCTO, PRECIO, CANTIDAD, CODIGO_PRODUCTO);
            Limpiar();
            ListadoTabla();

        }

        public void Limpiar()
        {
            txtCantidadProducto.Text = ("");
            txtCodProducto.Text = ("");
            txtPrecioProducto.Text = ("");
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
            exportarDatos(dgProducto);
        }
    }

}


