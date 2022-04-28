using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula30
{
    public partial class Form1 : Form
    {
        decimal valorTotal = 0.00m;

        public Form1()
        {
            InitializeComponent();
            lblPrecoTotal.Text = $"R$ {valorTotal}";
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lbNome.Items.Add(txtProduto.Text);
            lbPreco.Items.Add(txtPreco.Text);

            valorTotal += decimal.Parse(txtPreco.Text);
            lblPrecoTotal.Text = $"R$ {valorTotal}";
            txtProduto.Clear();
            txtPreco.Clear();
            txtProduto.Focus();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int index = lbNome.SelectedIndex;
            valorTotal -= decimal.Parse(lbPreco.Items[index].ToString());
            lblPrecoTotal.Text = $"R$ {valorTotal}";
            lbNome.Items.RemoveAt(index);
            lbPreco.Items.RemoveAt(index);
        }
    }
}
