using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnir_Click_1(object sender, EventArgs e)
        {
            int lim = 100;
            for (int i = 0; i < lim; i++)
            {
                dgvlista.Rows.Add(i + 1, txtnombre.Text);
            }
        }
    }
}
