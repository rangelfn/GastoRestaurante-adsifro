using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoRestaurante
{
    public partial class GastoRestaurante : Form
    {
        public GastoRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotalDesconto.Text = (Convert.ToDouble(
            txtTotalDaConta.Text) * 1.10).ToString("N");
        }

        private void txtTotalDaConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalDesconto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
