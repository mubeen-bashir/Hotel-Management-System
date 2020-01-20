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
    public partial class ManageReservation : Form
    {
        Reservation r = new Reservation();
        Guest gd = new Guest();
        //ManageReservation mr = new ManageReservation();
        public ManageReservation()
        {
            InitializeComponent();
        }

        private void textBoxReservationId_TextChanged(object sender, EventArgs e)
        {
            r.resid = int.Parse(textBoxReservationId.Text);

        }

        private void textBoxGuestId_TextChanged(object sender, EventArgs e)
        {
            r.guestid1 = textBoxGuestId.Text;
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            r.roomtype = comboBoxRoomType.Text;
        }

        private void comboBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            r.roomno = comboBoxRoomNo.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void AddNewReservation_Click(object sender, EventArgs e)
        {
            string dbconn = Customer.dbcon();
            MySqlConnection con = new MySqlConnection(dbconn);
            string query = "insert into hms.reservation(resid,guestid,room_type,room_no,datein,dateout) VALUES('" + r.resid + "','" + r.guestid1 + "','" + r.roomtype + "','" + r.roomno + "','" + dateTimePickerin + "','" + dateTimePicker2 + "');";
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
