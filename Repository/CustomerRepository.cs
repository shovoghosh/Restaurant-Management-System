using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        public bool UserLoginValidation(Customer cm)
        {
            string query = "SELECT * from Customer WHERE CId = '" + cm.CId + "' AND CPassword='" + cm.CPassword + "'";
            DatabaseConnectionClass dcc1 = new DatabaseConnectionClass();
            dcc1.ConnectWithDB();
            SqlDataReader sdr3 = dcc1.GetData(query);
            // dcc.CloseConnection();
            if (sdr3.Read())
            {
                cm.CName = sdr3["CName"].ToString();

                cm.CEmail = sdr3["CEmail"].ToString();
                cm.CPhone = sdr3["CPhone"].ToString();
                dcc1.CloseConnection();
                return true;
            }
            else
            {
                dcc1.CloseConnection();
                return false;
            }
        }


        public string ReturnUserName(string UserID)
        {

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT CName FROM Customer where CId = '" + UserID + "';", connection);
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

        public bool Addcustomer(string cid, string cname, string cpassword, string cphone, string cemail,  PictureBox cPictureBox)
        {

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction sqlTran = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                MemoryStream ms = new MemoryStream();

                cPictureBox.Image.Save(ms, cPictureBox.Image.RawFormat);

                byte[] aPicture = ms.GetBuffer();

                ms.Close();


                try
                {

                    command.Parameters.AddWithValue("@CId", cid);
                    command.Parameters.AddWithValue("@CName", cname);
                    command.Parameters.AddWithValue("@CPassword", cpassword);
                    command.Parameters.AddWithValue("@CPhone", cphone);
                    command.Parameters.AddWithValue("@CEmail", cemail);             
                    command.Parameters.AddWithValue("@CPicture", aPicture);


                    command.CommandText =
                     "INSERT into Customer (CId, CName, CPassword, CPhone, CEmail ,CPicture) values (@CId, @CName, @CPassword, @CPhone, @CEmail ,@CPicture)";

                    command.ExecuteNonQuery();
                    sqlTran.Commit();

                    connection.Close();


                    return true;
                }

                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";


        public ArrayList RetreiveAllcustomer()
        {
            ArrayList CustomerList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT CId, CName, CPassword, CPhone, CEmail, CPicture FROM Customer;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string CId = reader.GetString(0);
                        string CName = reader.GetString(1);
                        string CPassword = reader.GetString(2);
                        string CPhone = reader.GetString(3);
                        string CEmail = reader.GetString(4);
                        byte[] CPicture1 = (byte[])reader[5];

                        CustomerList.Add(new Customer() { CName = CName, CPassword = CPassword, CPhone = CPhone, CEmail = CEmail, CPicture = CPicture1, CId = CId });

                    }
                }
                reader.Close();

                return CustomerList;
            }
        }


        public List<Customer> Getcustomer(string CId)
        {
            string query = "SELECT CName,CPassword,CPhone,CEmail,CId from Customer WHERE CId = '" + CId + "'";
            List<Customer> Customerinfo = new List<Customer>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                Customer add = new Customer();

                string CName = sdr.GetString(0);
                string CPassword = sdr.GetString(1);
                string CPhone = sdr.GetString(2);
                string CEmail = sdr.GetString(3);
                
                string cidd = sdr.GetString(4);

                Customerinfo.Add(new Customer() { CId = cidd, CName = CName, CPassword = CPassword, CPhone = CPhone, CEmail = CEmail });

            }
            dcc.CloseConnection();
            return Customerinfo;
        }




    }

}
