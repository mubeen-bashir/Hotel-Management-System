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

    public partial class ManageRooms : Form
    {
        ManageRoom rm = new ManageRoom();
        public ManageRooms()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            rm.price = int.Parse(textBoxprice.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            rm.avali = comboBoxavali.Text;
        }

        private void txtBoxRoomNo_TextChanged(object sender, EventArgs e)
        {
            rm.room_no = int.Parse(txtBoxRoomNo.Text);
        }

        private void AddNewRoom_Click(object sender, EventArgs e)
        {
            string dbconn = Customer.dbcon();
            MySqlConnection con = new MySqlConnection();
            string query = "insert into hms.rooms(rno,rtype,rpric,avali) VALUES('" + rm.room_no + "','" + rm.roomType + "','" + rm.price + "','" + rm.avali + "');";
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

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rm.roomType = int.Parse(comboBoxRoomType.Text);
        }

        private void comboBoxavali_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
