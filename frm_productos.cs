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

        private void frm_productos_Load(object sender, EventArgs e) { }

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
                MessageBox.Show("El campo Precio no debe estar vacio","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            float PRECIO = float.Parse(txtPrecioProducto.Text);

            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Producto no debe estar vacio","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            //else
            //{
            //    //lblErrorNombreProducto.Text = ("");
            //    //lblErrorPrecio.Text = ("");
            //    //lblErrorPrecio.Text = ("");

            //    MessageBox.Show("Los Datos fueron guardados");


            //}

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            
            if (txtCodProducto.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo no debe estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            capaNegociosProductos.sp_eliminar_producto(Convert.ToInt32(txtCodProducto.Text));

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

           
 
                string datos = capaNegociosProductos.SP_UPDATE_PRODUCTOS(PRODUCTO, PRECIO, CANTIDAD, CODIGO_PRODUCTO);

            }
        }
    }


