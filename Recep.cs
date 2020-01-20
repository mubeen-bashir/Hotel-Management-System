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
    public partial class Recep : Form
    {
        public Recep()
        {
            InitializeComponent();
        }

        private void manageGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGuests mg = new ManageGuests();
            mg.Show();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRooms mr = new ManageRooms();
            mr.Show();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomer mc = new ManageCustomer();
            mc.Show();
        }

        private void calculatePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments py = new Payments();
            py.Show();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageReservation mr = new ManageReservation();
            mr.Show();
        }
    }
}
