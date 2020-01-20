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
    public partial class ManageManager : Form
    {
        Human h = new Human();
        public ManageManager()
        {
            InitializeComponent();
        }

        private void GAddNew_Click(object sender, EventArgs e)
        {  string dbconn = Customer.dbcon();
        MySqlConnection con = new MySqlConnection(dbconn);
            string query = "insert into hms.manager(id2,name,cnic,email,gender,age,phone,address) VALUES('" + h.hid + "','" + h.name + "','" + h.cnic + "','" + h.email + "','" + h.gender + "','" + h.age + "','" + h.phone + "','" + h.address + "');";
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
            h.hid = textBoxmid.Text;
        }

        private void textBoxmName_TextChanged(object sender, EventArgs e)
        {
            h.name = textBoxmName.Text;
        }

        private void textBoxmCNIC_TextChanged(object sender, EventArgs e)
        {
            h.cnic = textBoxmCNIC.Text;
        }

        private void textBoxmEmail_TextChanged(object sender, EventArgs e)
        {
            h.email = textBoxmEmail.Text;
        }

        private void comboBoxmGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            h.gender = comboBoxmGender.Text;
        }

        private void textBoxmAge_TextChanged(object sender, EventArgs e)
        {
            h.age = int.Parse(textBoxmAge.Text);
        }

        private void textBoxmPhone_TextChanged(object sender, EventArgs e)
        {
            h.phone = textBoxmPhone.Text;
        }

        private void textBoxmAddress_TextChanged(object sender, EventArgs e)
        {
            h.address = textBoxmAddress.Text;
        }

        private void GEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "update hms.customer id='" + h.hid + "',name='" + h.name + "',CNIC='" + h.cnic + "',email='" + h.email + "',Age='" + h.age + "',Phone='" + h.phone + "',Gender='" + h.gender + "', address='" + h.address + "' where name='" + this.textBoxmName + "';";
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
