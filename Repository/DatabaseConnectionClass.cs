using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Repository
{
    
        public class DatabaseConnectionClass
        {
            private SqlConnection myConnection;
            private SqlCommand myCommand;




            public DatabaseConnectionClass()
            {
                string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";
                myConnection = new SqlConnection(connectionString);


               

            }


            public void ConnectWithDB()
            {
                myConnection.Open();
            }


            public void CloseConnection()
            {
                myConnection.Close();
            }


            public SqlDataReader GetData(string query)
            {
                myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteReader();


               
            }


            public int ExecuteSQL(string query)
            {
                myCommand = new SqlCommand(query, myConnection);         
                return myCommand.ExecuteNonQuery();
            }
        }     
    }

