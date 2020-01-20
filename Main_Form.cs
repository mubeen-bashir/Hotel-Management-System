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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }


        private void Main_Form_Load(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service se = new Service();
            se.Show();
        }

        private void manageManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageManager mm = new ManageManager();
            mm.Show();
        }

        private void manageReceptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageReceptionist mre = new ManageReceptionist();
            mre.Show();
        }

        private void inventoryItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryItems ii = new InventoryItems();
            ii.Show();
        }

    }
}
