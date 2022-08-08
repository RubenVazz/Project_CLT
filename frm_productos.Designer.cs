namespace f2
{
    partial class frm_productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnListarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblErrorCodProducto = new System.Windows.Forms.Label();
            this.lblErrorNombreProducto = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(39, 325);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(111, 39);
            this.btnModificarProducto.TabIndex = 21;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(201, 258);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(111, 39);
            this.btnEliminarProducto.TabIndex = 20;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnListarProducto
            // 
            this.btnListarProducto.Location = new System.Drawing.Point(201, 327);
            this.btnListarProducto.Name = "btnListarProducto";
            this.btnListarProducto.Size = new System.Drawing.Size(111, 35);
            this.btnListarProducto.TabIndex = 19;
            this.btnListarProducto.Text = "Listar";
            this.btnListarProducto.UseVisualStyleBackColor = true;
            this.btnListarProducto.Click += new System.EventHandler(this.btnListarProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(39, 258);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(111, 39);
            this.btnGuardarProducto.TabIndex = 18;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // dgProducto
            // 
            this.dgProducto.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Location = new System.Drawing.Point(406, 12);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.RowHeadersWidth = 51;
            this.dgProducto.RowTemplate.Height = 24;
            this.dgProducto.Size = new System.Drawing.Size(458, 324);
            this.dgProducto.TabIndex = 17;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(136, 93);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(207, 22);
            this.txtProducto.TabIndex = 16;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(136, 151);
            this.txtPrecioProducto.MaxLength = 50;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(207, 22);
            this.txtPrecioProducto.TabIndex = 15;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(136, 32);
            this.txtCodProducto.MaxLength = 50;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(207, 22);
            this.txtCodProducto.TabIndex = 14;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(24, 35);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(111, 16);
            this.lblCodProducto.TabIndex = 13;
            this.lblCodProducto.Text = "Codigo Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(24, 154);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(24, 96);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto:";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(136, 211);
            this.txtCantidadProducto.MaxLength = 50;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(207, 22);
            this.txtCantidadProducto.TabIndex = 23;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(24, 214);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblErrorCodProducto
            // 
            this.lblErrorCodProducto.AutoSize = true;
            this.lblErrorCodProducto.Location = new System.Drawing.Point(133, 57);
            this.lblErrorCodProducto.Name = "lblErrorCodProducto";
            this.lblErrorCodProducto.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCodProducto.TabIndex = 24;
            // 
            // lblErrorNombreProducto
            // 
            this.lblErrorNombreProducto.AutoSize = true;
            this.lblErrorNombreProducto.Location = new System.Drawing.Point(133, 118);
            this.lblErrorNombreProducto.Name = "lblErrorNombreProducto";
            this.lblErrorNombreProducto.Size = new System.Drawing.Size(0, 16);
            this.lblErrorNombreProducto.TabIndex = 25;
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.Location = new System.Drawing.Point(133, 239);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCantidad.TabIndex = 26;
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Location = new System.Drawing.Point(133, 176);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(0, 16);
            this.lblErrorPrecio.TabIndex = 27;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(406, 342);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(111, 39);
            this.btnExportar.TabIndex = 28;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(876, 436);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.lblErrorCantidad);
            this.Controls.Add(this.lblErrorNombreProducto);
            this.Controls.Add(this.lblErrorCodProducto);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnListarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.lblCodProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblProducto);
            this.Name = "frm_productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frm_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnListarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblErrorCodProducto;
        private System.Windows.Forms.Label lblErrorNombreProducto;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.Button btnExportar;
    }
}