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
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void chefsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cheff ch = new Cheff();
            ch.Show();
        }

        private void waiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waiters wa = new Waiters();
            wa.Show();
        }

        private void foodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Food_Item fi = new Food_Item();
            fi.Show();
        }
    }
}
