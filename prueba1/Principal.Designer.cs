
namespace prueba1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MsCreditos = new System.Windows.Forms.MenuStrip();
            this.btnInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.rbRestaurantes = new System.Windows.Forms.RadioButton();
            this.rbBebidas = new System.Windows.Forms.RadioButton();
            this.rbCafetria = new System.Windows.Forms.RadioButton();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.cboUnidades = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.MsCreditos.SuspendLayout();
            this.gbCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsCreditos
            // 
            this.MsCreditos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MsCreditos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MsCreditos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInformacion});
            this.MsCreditos.Location = new System.Drawing.Point(0, 384);
            this.MsCreditos.Name = "MsCreditos";
            this.MsCreditos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MsCreditos.Size = new System.Drawing.Size(534, 27);
            this.MsCreditos.TabIndex = 0;
            this.MsCreditos.Text = "menuStrip1";
            this.MsCreditos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MsCreditos_ItemClicked);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(88, 23);
            this.btnInformacion.Text = "Acerca de";
            // 
            // gbCategorias
            // 
            this.gbCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbCategorias.Controls.Add(this.rbRestaurantes);
            this.gbCategorias.Controls.Add(this.rbBebidas);
            this.gbCategorias.Controls.Add(this.rbCafetria);
            this.gbCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbCategorias.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCategorias.Location = new System.Drawing.Point(12, 50);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(156, 275);
            this.gbCategorias.TabIndex = 1;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "Categorias";
            // 
            // rbRestaurantes
            // 
            this.rbRestaurantes.AutoSize = true;
            this.rbRestaurantes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbRestaurantes.Location = new System.Drawing.Point(20, 167);
            this.rbRestaurantes.Name = "rbRestaurantes";
            this.rbRestaurantes.Size = new System.Drawing.Size(126, 25);
            this.rbRestaurantes.TabIndex = 7;
            this.rbRestaurantes.TabStop = true;
            this.rbRestaurantes.Text = "Restaurantes";
            this.rbRestaurantes.UseVisualStyleBackColor = true;
            this.rbRestaurantes.CheckedChanged += new System.EventHandler(this.rbRestaurantes_CheckedChanged);
            // 
            // rbBebidas
            // 
            this.rbBebidas.AutoSize = true;
            this.rbBebidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbBebidas.Location = new System.Drawing.Point(20, 114);
            this.rbBebidas.Name = "rbBebidas";
            this.rbBebidas.Size = new System.Drawing.Size(88, 25);
            this.rbBebidas.TabIndex = 6;
            this.rbBebidas.TabStop = true;
            this.rbBebidas.Text = "Bebidas";
            this.rbBebidas.UseVisualStyleBackColor = true;
            this.rbBebidas.CheckedChanged += new System.EventHandler(this.rbBebidas_CheckedChanged);
            // 
            // rbCafetria
            // 
            this.rbCafetria.AutoSize = true;
            this.rbCafetria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCafetria.Location = new System.Drawing.Point(20, 57);
            this.rbCafetria.Name = "rbCafetria";
            this.rbCafetria.Size = new System.Drawing.Size(97, 25);
            this.rbCafetria.TabIndex = 5;
            this.rbCafetria.TabStop = true;
            this.rbCafetria.Text = "Cafeteria";
            this.rbCafetria.UseVisualStyleBackColor = true;
            this.rbCafetria.CheckedChanged += new System.EventHandler(this.rbCafetria_CheckedChanged);
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarPedido.Location = new System.Drawing.Point(357, 339);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(153, 42);
            this.btnConfirmarPedido.TabIndex = 2;
            this.btnConfirmarPedido.Text = "Confirmar pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = false;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(194, 117);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(141, 23);
            this.cboProductos.TabIndex = 3;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // cboUnidades
            // 
            this.cboUnidades.FormattingEnabled = true;
            this.cboUnidades.Location = new System.Drawing.Point(372, 117);
            this.cboUnidades.Name = "cboUnidades";
            this.cboUnidades.Size = new System.Drawing.Size(138, 23);
            this.cboUnidades.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(372, 202);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(138, 23);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(357, 310);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(153, 23);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProducto.Location = new System.Drawing.Point(194, 191);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(153, 38);
            this.btnAgregarProducto.TabIndex = 7;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.Location = new System.Drawing.Point(194, 93);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(87, 21);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "Productos";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnidades.Location = new System.Drawing.Point(431, 93);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(82, 21);
            this.lblUnidades.TabIndex = 9;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(452, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 21);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(401, 286);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 21);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total a pagar";
            // 
            // btnSalir1
            // 
            this.btnSalir1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir1.Location = new System.Drawing.Point(194, 351);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(70, 30);
            this.btnSalir1.TabIndex = 12;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = true;
            this.btnSalir1.Click += new System.EventHandler(this.btnSalir1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboUnidades);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.MsCreditos);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosYa";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MsCreditos.ResumeLayout(false);
            this.MsCreditos.PerformLayout();
            this.gbCategorias.ResumeLayout(false);
            this.gbCategorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsCreditos;
        private System.Windows.Forms.ToolStripMenuItem btnInformacion;
        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.RadioButton rbRestaurantes;
        private System.Windows.Forms.RadioButton rbBebidas;
        private System.Windows.Forms.RadioButton rbCafetria;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.ComboBox cboUnidades;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSalir1;
    }
}

