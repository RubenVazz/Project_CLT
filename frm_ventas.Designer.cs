namespace f2
{
    partial class frm_ventas
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnModificarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnListarVenta = new System.Windows.Forms.Button();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodVenta = new System.Windows.Forms.TextBox();
            this.lblCodVenta = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblErrorPrecioVenta = new System.Windows.Forms.Label();
            this.lblErrorCodCliente = new System.Windows.Forms.Label();
            this.lblErrorProducto = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.lblErrorCodProducto = new System.Windows.Forms.Label();
            this.lblErrorCodVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(143, 211);
            this.txtNombreProducto.MaxLength = 50;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(207, 22);
            this.txtNombreProducto.TabIndex = 36;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(7, 214);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 35;
            this.lblProducto.Text = "Producto:";
            // 
            // btnModificarVenta
            // 
            this.btnModificarVenta.Location = new System.Drawing.Point(12, 433);
            this.btnModificarVenta.Name = "btnModificarVenta";
            this.btnModificarVenta.Size = new System.Drawing.Size(111, 39);
            this.btnModificarVenta.TabIndex = 34;
            this.btnModificarVenta.Text = "Modificar";
            this.btnModificarVenta.UseVisualStyleBackColor = true;
            this.btnModificarVenta.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(174, 366);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(111, 39);
            this.btnEliminarVenta.TabIndex = 33;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnListarVenta
            // 
            this.btnListarVenta.Location = new System.Drawing.Point(174, 435);
            this.btnListarVenta.Name = "btnListarVenta";
            this.btnListarVenta.Size = new System.Drawing.Size(111, 35);
            this.btnListarVenta.TabIndex = 32;
            this.btnListarVenta.Text = "Listar";
            this.btnListarVenta.UseVisualStyleBackColor = true;
            this.btnListarVenta.Click += new System.EventHandler(this.btnListarProducto_Click);
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(12, 366);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(111, 39);
            this.btnGuardarVenta.TabIndex = 31;
            this.btnGuardarVenta.Text = "Guardar";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // dgVentas
            // 
            this.dgVentas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Location = new System.Drawing.Point(387, 12);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.RowHeadersWidth = 51;
            this.dgVentas.RowTemplate.Height = 24;
            this.dgVentas.Size = new System.Drawing.Size(458, 324);
            this.dgVentas.TabIndex = 30;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(143, 93);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(207, 22);
            this.txtProducto.TabIndex = 29;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(143, 151);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(207, 22);
            this.txtCantidad.TabIndex = 28;
            // 
            // txtCodVenta
            // 
            this.txtCodVenta.Location = new System.Drawing.Point(143, 32);
            this.txtCodVenta.MaxLength = 50;
            this.txtCodVenta.Name = "txtCodVenta";
            this.txtCodVenta.Size = new System.Drawing.Size(207, 22);
            this.txtCodVenta.TabIndex = 27;
            // 
            // lblCodVenta
            // 
            this.lblCodVenta.AutoSize = true;
            this.lblCodVenta.Location = new System.Drawing.Point(7, 35);
            this.lblCodVenta.Name = "lblCodVenta";
            this.lblCodVenta.Size = new System.Drawing.Size(109, 16);
            this.lblCodVenta.TabIndex = 26;
            this.lblCodVenta.Text = "Codigo de venta:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 154);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(7, 96);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(130, 16);
            this.lblCodProducto.TabIndex = 24;
            this.lblCodProducto.Text = "Codigo de Producto:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(143, 305);
            this.txtPrecioVenta.MaxLength = 50;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(207, 22);
            this.txtPrecioVenta.TabIndex = 40;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(7, 308);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(106, 16);
            this.lblPrecioVenta.TabIndex = 39;
            this.lblPrecioVenta.Text = "Precio de Venta:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(143, 258);
            this.txtCodCliente.MaxLength = 50;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(207, 22);
            this.txtCodCliente.TabIndex = 38;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(7, 261);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(117, 16);
            this.lblCodCliente.TabIndex = 37;
            this.lblCodCliente.Text = "Codigo de Cliente:";
            // 
            // lblErrorPrecioVenta
            // 
            this.lblErrorPrecioVenta.AutoSize = true;
            this.lblErrorPrecioVenta.Location = new System.Drawing.Point(141, 331);
            this.lblErrorPrecioVenta.Name = "lblErrorPrecioVenta";
            this.lblErrorPrecioVenta.Size = new System.Drawing.Size(0, 16);
            this.lblErrorPrecioVenta.TabIndex = 41;
            // 
            // lblErrorCodCliente
            // 
            this.lblErrorCodCliente.AutoSize = true;
            this.lblErrorCodCliente.Location = new System.Drawing.Point(141, 284);
            this.lblErrorCodCliente.Name = "lblErrorCodCliente";
            this.lblErrorCodCliente.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCodCliente.TabIndex = 42;
            // 
            // lblErrorProducto
            // 
            this.lblErrorProducto.AutoSize = true;
            this.lblErrorProducto.Location = new System.Drawing.Point(141, 237);
            this.lblErrorProducto.Name = "lblErrorProducto";
            this.lblErrorProducto.Size = new System.Drawing.Size(0, 16);
            this.lblErrorProducto.TabIndex = 43;
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.Location = new System.Drawing.Point(141, 177);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCantidad.TabIndex = 44;
            // 
            // lblErrorCodProducto
            // 
            this.lblErrorCodProducto.AutoSize = true;
            this.lblErrorCodProducto.Location = new System.Drawing.Point(141, 119);
            this.lblErrorCodProducto.Name = "lblErrorCodProducto";
            this.lblErrorCodProducto.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCodProducto.TabIndex = 45;
            // 
            // lblErrorCodVenta
            // 
            this.lblErrorCodVenta.AutoSize = true;
            this.lblErrorCodVenta.Location = new System.Drawing.Point(141, 58);
            this.lblErrorCodVenta.Name = "lblErrorCodVenta";
            this.lblErrorCodVenta.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCodVenta.TabIndex = 46;
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 557);
            this.Controls.Add(this.lblErrorCodVenta);
            this.Controls.Add(this.lblErrorCodProducto);
            this.Controls.Add(this.lblErrorCantidad);
            this.Controls.Add(this.lblErrorProducto);
            this.Controls.Add(this.lblErrorCodCliente);
            this.Controls.Add(this.lblErrorPrecioVenta);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnModificarVenta);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.btnListarVenta);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.dgVentas);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodVenta);
            this.Controls.Add(this.lblCodVenta);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodProducto);
            this.Name = "frm_ventas";
            this.Text = "frm_ventas";
            this.Load += new System.EventHandler(this.frm_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnListarVenta;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodVenta;
        private System.Windows.Forms.Label lblCodVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblErrorPrecioVenta;
        private System.Windows.Forms.Label lblErrorCodCliente;
        private System.Windows.Forms.Label lblErrorProducto;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.Label lblErrorCodProducto;
        private System.Windows.Forms.Label lblErrorCodVenta;
    }
}