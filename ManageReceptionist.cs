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
    public partial class ManageReceptionist : Form
    {
        Human r = new Human();
        public ManageReceptionist()
        {
            InitializeComponent();
        }

        private void GEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "update hms.customer id='" + r.hid + "',name='" + r.name + "',CNIC='" + r.cnic + "',email='" + r.email + "',Age='" + r.age + "',Phone='" + r.phone + "',Gender='" + r.gender + "', address='" + r.address + "' where name='" + this.textBoxGName + "';";
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

        private void txtBoxGId_TextChanged(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            r.hid = txtBoxGId.Text;
        }

        private void textBoxGName_TextChanged(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            r.name = textBoxGName.Text;
        }

        private void textBoxGCNIC_TextChanged(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            r.cnic = textBoxGCNIC.Text;
            
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
           
             Receptionist r = new Receptionist();
             r.email = textBoxEmail.Text;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             Receptionist r = new Receptionist();
             r.gender = comboBoxGender.Text;
            
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            r.age = Convert.ToInt32(textBoxAge.Text);
            
        }

        private void textBoxGPhone_TextChanged(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            r.phone = textBoxGPhone.Text;
            
        }

        private void textBoxGAddress_TextChanged(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            r.address = textBoxGAddress.Text;
            
        }
    }
}
