using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class frmPrincipal : Form
    {
        private double precio;
        private double total;
        public frmPrincipal()
        {
            InitializeComponent();
            this.precio = 0;
            this.total = 0;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            txtPrecio.Text = 500.ToString();
            precio = Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(cboUnidades.SelectedItem);
            total += precio;
            txtTotal.Text = total.ToString();
        }
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pedido confirmado por un saldo de {txtTotal.Text}");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtPrecio.Text = 0.ToString();
            txtTotal.Text = 0.ToString();
            cboUnidades.Items.Add(1);
            cboUnidades.Items.Add(2);
            cboUnidades.Items.Add(3);
            cboUnidades.Items.Add(4);
        }
    }
}
