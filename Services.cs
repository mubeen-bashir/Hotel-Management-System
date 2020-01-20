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
    public partial class Service : Form
    {
        Servicess sr = new Servicess();
        public Service()
        {
            InitializeComponent();
        }

        private void txtBoxGId_TextChanged(object sender, EventArgs e)
        {
            sr.sername = textBoxsername.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbconn = Customer.dbcon();
            MySqlConnection con = new MySqlConnection(dbconn);

            string query = "insert into hms.services(servicename,servicetype) VALUES('" + sr.sername + "','" + sr.servtype + "');";
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

        private void textBoxsertype_TextChanged(object sender, EventArgs e)
        {
            sr.servtype = textBoxsertype.Text;
        }
    }
}
