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
    public partial class ManageGuests : Form
    {
        public ManageGuests()
        {
            InitializeComponent();
        }

        Guest gs = new Guest();

      private void CAddNew_Click(object sender, EventArgs e)
        {
            

          //  txtBoxCId.Text = "";
         //   textBoxName.Text = "";
          //  textBoxCNIC.Text = "";
           // textBoxEmailId.Text = "";
           // comboBoxGender.Text = "";
          //  textBoxAge.Text = "";
          //  textBoxCPhone.Text = "";
          //  textBoxCAddress.Text = "";
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GAddNew_Click(object sender, EventArgs e)
        {
            string dbconn = Customer.dbcon();
            MySqlConnection con = new MySqlConnection(dbconn);
            //  con.Open();
            //   if (con.State == ConnectionState.Open)
            //  {
            //      MessageBox.Show("Database Connected");
            // }
            //   else
            //  {
            //       MessageBox.Show("Database not Connected");
            //    }
            Guest gd = new Guest();
          //  string query = "insert into hms.guest(id,name,cnic,email,gender,age,phone,address,room_no,room_type,luggage,payment,duration) VALUES('" + gd.hid + "','" + gd.name + "','" + gd.cnic + "','" + gd.email + "','" + gd.gender + "','" + gd.age + "','" + gd.phone + "','" + gd.address + "');";
            string query = "insert into hms.guest(id1,name,cnic,email,gender,age,phone,address,room_no,room_type,luggage,payment,duration) VALUES('" + gd.hid + "','" + gd.name + "','" + gd.cnic + "','" + gd.email + "','" + gd.gender + "','" + gd.age + "','" + gd.phone + "','" + gd.address + "','"+gd.room_no+"','"+gd.room_type+"','"+gd.luggage+"','"+gd.payment+"','"+gd.duration+"');";
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

        private void txtBoxGId_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.hid = textBoxGid.Text;
        }

        private void textBoxGName_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.name = textBoxGName.Text;
        }

        private void textBoxGCNIC_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.cnic = textBoxGCNIC.Text;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.email = textBoxEmail.Text;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.gender = comboBoxGender.Text;
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.age = int.Parse(textBoxAge.Text);
        }

        private void textBoxGPhone_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.phone = textBoxGPhone.Text;
        }

        private void textBoxGAddress_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.address = textBoxGAddress.Text;
        }

        private void textBoxPY_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.payment = int.Parse(textBoxPY.Text);
        }

        private void textBoxLU_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.luggage = int.Parse(textBoxLU.Text);
        }

        private void textBoxRN_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.room_no = int.Parse(textBoxRN.Text);
        }

        private void textBoxRT_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.room_type = int.Parse(textBoxRT.Text);
        }

        private void textBoxDU_TextChanged(object sender, EventArgs e)
        {
            Guest gd = new Guest();
            gd.duration = int.Parse(textBoxDU.Text);
        }

        private void GEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "update hms.customer id='" + gs.hid + "',name='" + gs.name + "',CNIC='" + gs.cnic + "',email='" + gs.email + "',Age='" + gs.age + "',Phone='" + gs.phone + "',Gender='" + gs.gender + "', address='" + gs.address + "' where name='" + this.textBoxGName + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
