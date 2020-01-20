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
    public partial class ManageCustomer : Form
    {
        Customer c1=new Customer();
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
           
            
        }

        private void CAddNew_Click(object sender, EventArgs e)
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

            string query = "insert into hms.customer(id,name,cnic,email,gender,age,phone,address) VALUES('" + c1.hid + "','" + c1.name + "','" + c1.cnic + "','" + c1.email + "','" + c1.gender + "','" + c1.age + "','" + c1.phone + "','" + c1.address + "');";
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


          //  txtBoxCId.Text = "";
         //   textBoxName.Text = "";
          //  textBoxCNIC.Text = "";
           // textBoxEmailId.Text = "";
           // comboBoxGender.Text = "";
          //  textBoxAge.Text = "";
          //  textBoxCPhone.Text = "";
          //  textBoxCAddress.Text = "";
             
        }

        private void txtBoxCId_TextChanged(object sender, EventArgs e)
        {
            c1.hid = txtBoxCId.Text;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            c1.name = textBoxName.Text;
        }

        private void textBoxCNIC_TextChanged(object sender, EventArgs e)
        {
            c1.cnic = textBoxCNIC.Text;
        }

        private void textBoxEmailId_TextChanged(object sender, EventArgs e)
        {
            c1.email = textBoxEmailId.Text;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1.gender = comboBoxGender.Text;
        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            c1.age = int.Parse(textBoxAge.Text);
        }

        private void textBoxCPhone_TextChanged(object sender, EventArgs e)
        {
            c1.phone = textBoxCPhone.Text;
        }

        private void textBoxCAddress_TextChanged(object sender, EventArgs e)
        {
            c1.address = textBoxCAddress.Text;
        }

        private void CEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost; username=root; password=; database = oop";
                string Query = "update hms.customer id='" + c1.hid + "',name='" + c1.name + "',CNIC='" + c1.cnic + "',email='" + c1.email + "',Age='" + c1.age + "',Phone='" + c1.phone + "',Gender='" + c1.gender + "', address='" + c1.address + "' where name='" + this.textBoxName + "';";
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
