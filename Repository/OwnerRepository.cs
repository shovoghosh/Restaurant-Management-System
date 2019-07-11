using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OwnerRepository : IOwnerRepository
    {

        public bool UserLoginValidation(Owner own)
        {
            string query = "SELECT * from Owner WHERE OId = '" + own.OId + "' AND OPassword='" + own.OPassword + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr1 = dcc.GetData(query);
            // dcc.CloseConnection();
            if (sdr1.Read())
            {
                own.OName = sdr1["OName"].ToString();
             
                own.OEmail = sdr1["OEmail"].ToString();
                own.OPhone = sdr1["OPhone"].ToString();
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }



        public string ReturnUserName(string UserID)
        {

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT OName FROM Owner where OId = '" + UserID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string UserName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserName = reader.GetString(0);
                    }
                }
                reader.Close();

                return UserName;
            }
        }

        public List<Owner> Getowner(string OId)
        {
            string query = "SELECT OName,OPassword,OPhone,OEmail,OId from Owner WHERE OId = '" + OId + "'";
            List<Owner> Ownerinfo = new List<Owner>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                Owner add = new Owner();

                string OName = sdr.GetString(0);
                string OPassword = sdr.GetString(1);
                string OPhone = sdr.GetString(2);
                string OEmail = sdr.GetString(3);

                string Oidd = sdr.GetString(4);

                Ownerinfo.Add(new Owner() { OId = Oidd, OName = OName, OPassword = OPassword, OPhone = OPhone, OEmail = OEmail });

            }
            dcc.CloseConnection();
            return Ownerinfo;
        }


    }
}
