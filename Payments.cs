using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
   
    public partial class Payments : Form
    {
        Payment p = new Payment();
        public Payments()
        {
            InitializeComponent();
        }

        private void txtBoxGId_TextChanged(object sender, EventArgs e)
        {
            p.roomcharges = int.Parse(txtBoxrcharg.Text);
        }

        private void textBoxGName_TextChanged(object sender, EventArgs e)
        {
            p.rescharges = int.Parse(textBoxrescharg.Text);
        }

        private void textBoxGCNIC_TextChanged(object sender, EventArgs e)
        {
            p.sercharges = int.Parse(textBoxaddser.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            p.paymentcal();
        }
    }
}
