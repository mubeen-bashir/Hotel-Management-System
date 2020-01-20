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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void RemoveReservation_Click(object sender, EventArgs e)
        {
            Connect con = new Connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            /*  string query = "SELECT * FROM `user` WHERE 'username'=@user AND 'password' = @pass";
              command.CommandText = query;
              command.Connection = con.getConnection();
              command.Parameters.Add("@user", MySqlDbType.VarChar).Value = textBoxUserId.Text;
              command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassId.Text;
              adapter.SelectCommand = command;
              adapter.Fill(table);
             
             */
            if (textBoxUserId.Text == "" || textBoxPassId.Text == "")
              {
                  MessageBox.Show("Please Enter Something User Name or Password is Empty","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                  return;
              }
            if (textBoxUserId.Text != "admin" || textBoxPassId.Text != "admin")
              {
                  MessageBox.Show("Enter Valid User Name and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
              }
             this.Hide();
              Main_Form main = new Main_Form();
              main.Show();
             
            //if the username & password exists
            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recep m1 =new Recep();
            m1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm2 m2 = new MainForm2();
            m2.Show();
        }
    }
}
