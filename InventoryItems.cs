using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace HotelManagementSystem
{
    public partial class InventoryItems : Form
    {
        Inventory_Items it = new Inventory_Items();
        public InventoryItems()
        {
            InitializeComponent();
        }

        private void txtBoxGId_TextChanged(object sender, EventArgs e)
        {
            it.inventoryID =int.Parse(txtBoxGId.Text);
        }

        private void textBoxGName_TextChanged(object sender, EventArgs e)
        {
            it.inventoryItem = textBoxGName.Text;
        }

        private void GAddNew_Click(object sender, EventArgs e)
        {
            string dbconn = Customer.dbcon();
            MySqlConnection con = new MySqlConnection(dbconn);
            string query = "insert into hms.inventory(id4,iname) VALUES('" + it.inventoryID+ "','" + it.inventoryItem + "');";
            con.Open();
            MySqlCommand comm = new MySqlCommand(query, con);
            if (comm.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
            con.Close();

        }
    }
}
