using PedidosYa;
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
            precio = Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(cboUnidades.SelectedItem);
            total += precio;
            txtTotal.Text = total.ToString();
        }
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == 0.ToString())
            {
                MessageBox.Show("No hay ningún artículo seleccionado.");
            }
            else
            {
                MessageBox.Show($"Pedido confirmado por un saldo de {txtTotal.Text} pesos.");
            }            
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

        private void rbCafetria_CheckedChanged(object sender, EventArgs e)
        {
            cboProductos.Items.Clear();
            cboProductos.Items.Add("Merienda light");
            cboProductos.Items.Add("Merienda continental");
            cboProductos.Items.Add("Desayuno");
        }

        private void rbBebidas_CheckedChanged(object sender, EventArgs e)
        {
            cboProductos.Items.Clear();
            cboProductos.Items.Add("Agua mineral");
            cboProductos.Items.Add("Agua tónica");
            cboProductos.Items.Add("Agua carbonatada");
        }

        private void rbRestaurantes_CheckedChanged(object sender, EventArgs e)
        {
            cboProductos.Items.Clear();
            cboProductos.Items.Add("Pizza mozzarella");
            cboProductos.Items.Add("Pizza calabresa");
            cboProductos.Items.Add("Calzone 4 quesos");
        }

        private void MsCreditos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmSecundaria frmSecundaria2 = new frmSecundaria();
            frmSecundaria2.Show();
            this.Hide();
        }       

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProductos.Items.Contains("Merienda light"))
            {
                 if(cboProductos.SelectedIndex == 0)
                 {
                    txtPrecio.Text = 350.ToString();
                 }
                if (cboProductos.SelectedIndex == 1)
                {
                    txtPrecio.Text = 400.ToString();
                }
                if (cboProductos.SelectedIndex == 2)
                {
                    txtPrecio.Text = 300.ToString();
                }
            }
            if (cboProductos.Items.Contains("Agua mineral"))
            {
                if (cboProductos.SelectedIndex == 0)
                {
                    txtPrecio.Text = 100.ToString();
                }
                if (cboProductos.SelectedIndex == 1)
                {
                    txtPrecio.Text = 180.ToString();
                }
                if (cboProductos.SelectedIndex == 2)
                {
                    txtPrecio.Text = 130.ToString();
                }
            }
            if (cboProductos.Items.Contains("Pizza mozzarella"))
            {
                if (cboProductos.SelectedIndex == 0)
                {
                    txtPrecio.Text = 500.ToString();
                }
                if (cboProductos.SelectedIndex == 1)
                {
                    txtPrecio.Text = 550.ToString();
                }
                if (cboProductos.SelectedIndex == 2)
                {
                    txtPrecio.Text = 650.ToString();
                }
            }
        }
    }
}
