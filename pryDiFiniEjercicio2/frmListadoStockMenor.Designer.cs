namespace pryDiFiniEjercicio2
{
    partial class frmListadoStockMenor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPromedioPrecio = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalInventario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPromedioPrecio);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lblCantidadProductos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTotalInventario);
            this.groupBox2.Controls.Add(this.lblTitulo);
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(724, 383);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de datos";
            // 
            // lblPromedioPrecio
            // 
            this.lblPromedioPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioPrecio.Location = new System.Drawing.Point(591, 325);
            this.lblPromedioPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioPrecio.Name = "lblPromedioPrecio";
            this.lblPromedioPrecio.Size = new System.Drawing.Size(113, 25);
            this.lblPromedioPrecio.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 325);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(432, 325);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(211, 31);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Precio Promedio:";
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.Location = new System.Drawing.Point(591, 279);
            this.lblCantidadProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(113, 25);
            this.lblCantidadProductos.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad de productos:";
            // 
            // lblTotalInventario
            // 
            this.lblTotalInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInventario.Location = new System.Drawing.Point(591, 235);
            this.lblTotalInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInventario.Name = "lblTotalInventario";
            this.lblTotalInventario.Size = new System.Drawing.Size(113, 25);
            this.lblTotalInventario.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(432, 235);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Total inventario:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProductos.Location = new System.Drawing.Point(15, 34);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(689, 185);
            this.dgvProductos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Productos";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmListadoStockMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmListadoStockMenor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Stock bajo";
            this.Load += new System.EventHandler(this.frmListadoStockMenor_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPromedioPrecio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalInventario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}