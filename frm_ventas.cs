using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void btnListarProducto_Click(object sender, EventArgs e)
        {
            ListadoTabla();
        }

        public void ListadoTabla()
        {
            dgVentas.DataSource = null;
            dgVentas.DataSource = capaNegociosVentas.SP_LISTAR_VENTAS();
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

        }
        
            
        

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodVenta.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                capaNegociosVentas.sp_eliminar_ventas(Convert.ToInt32(txtCodVenta.Text));

            

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
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CODIGO_VENTA = Convert.ToInt32(txtCodVenta.Text);

            string datos = capaNegociosVentas.SP_UPDATE_VENTAS(PI_CANTIDAD, PI_CODIGO_PRODUCTO,PI_NOMBRE_PRODUCTO,PI_PRECIO_VENTA,PI_CODIGO_CLIENTE,PI_CODIGO_VENTA);

            

        }
    }
}
