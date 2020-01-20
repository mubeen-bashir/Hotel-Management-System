using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagementSystem
{
    class Connect
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hms");
   
    public MySqlConnection getConnection(){
    return connection;
}
        //Create a function to open the connection
    public void openConnection()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }
        //Create a function to Close the connection
    public void CloseConnection()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}
}
