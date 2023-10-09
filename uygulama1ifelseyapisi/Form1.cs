using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama1ifelseyapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            if (cbMavi.Checked)
            {
                lblYaz.Text = "mavi";
                lblYaz.BackColor = Color.Blue;
            }
            else
            {
                lblYaz.Text = "sarı";
                lblYaz.BackColor = Color.Yellow;
            }

        }
    }
}
