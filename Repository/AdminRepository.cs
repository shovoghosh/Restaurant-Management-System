using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Collections;
using System.Windows.Forms;

namespace Repository
{
    public class AdminRepository : IAdminRepository
    {
      

        public bool UserLoginValidation(Admin ad)
        {
            string query = "SELECT * from Admin WHERE AID = '" + ad.AId + "' AND APassword='" + ad.APassword + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            // dcc.CloseConnection();
            if (sdr.Read())
            {
                ad.AName = sdr["AName"].ToString();
                ad.ASal = Convert.ToDouble(sdr["ASal"]);

                ad.AEmail = sdr["AEmail"].ToString();
                ad.APhone = sdr["APhone"].ToString();
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
                SqlCommand command = new SqlCommand("SELECT AName FROM Admin where AId = '" + UserID + "';", connection);
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



    

        public List<Admin> GetAdmin(string AId)
        {
            string query = "SELECT AName,APassword,APhone,AEmail,ASal,AId from Admin WHERE AId = '" + AId + "'";
            List<Admin> admininfo = new List<Admin>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                Admin add = new Admin();

                string AName = sdr.GetString(0);
                string APassword = sdr.GetString(1);
                string APhone = sdr.GetString(2);
                string AEmail = sdr.GetString(3);
                double ASal = sdr.GetDouble(4);
                string aidd = sdr.GetString(5);

                admininfo.Add(new Admin() { AId = aidd, AName = AName, APassword = APassword, APhone=APhone,AEmail=AEmail,ASal=ASal });

            }
            dcc.CloseConnection();
            return admininfo;
        }





        public List<Admin> GetAllAdmin()
        {
            string query = "SELECT AId,AName,ASal,AEmail,APicture  from Admin";
            List<Admin> adminList = new List<Admin>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Admin add = new Admin();
                

                add.AId = sdr.GetString(0);
                add.AName = sdr.GetString(1);
                add.ASal = sdr.GetDouble(2);
                add.APhone = sdr.GetString(3);
                add.AEmail = sdr.GetString(4);
                add.APicture = (byte[])sdr[5];


                adminList.Add(add);
            }
            dcc.CloseConnection();
            return adminList;
        }


        public bool Delete(string AId)
        {
            try
            {
                string query = "DELETE From Admin WHERE AId='" + AId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(Admin ad)
        {
            try
            {
                string query = "UPDATE Admin SET AName = '" + ad.AName + "', ASal =" + ad.ASal + ", APhone = '" + ad.APhone + "WHERE AId = '" + ad.AId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


      

        



        public bool Insert(Admin ad  )
        {


                try
                {

                    DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                    dcc.ConnectWithDB();
                    string query = "INSERT into Admin VALUES ('" + ad.AId + "', '" + ad.AName + "','" + ad.APassword + "', '" + ad.APhone + "', " + ad.AEmail + ", '" + ad.ASal + "','" + ad.APicture + "')";



                    int x = dcc.ExecuteSQL(query);
                    dcc.CloseConnection();
                    return true;
                }

                catch (Exception ex)
                {
                    return false;
                }
            }






        public bool AddAdmin(string aid, string aname, string apassword, string aphone, string aemail, string asal, PictureBox aPictureBox)
        {

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction sqlTran = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                MemoryStream ms = new MemoryStream();

                aPictureBox.Image.Save(ms, aPictureBox.Image.RawFormat);

                byte[] aPicture = ms.GetBuffer();

                ms.Close();

               
                try
                {

                    command.Parameters.AddWithValue("@AId", aid);
                    command.Parameters.AddWithValue("@AName", aname);
                    command.Parameters.AddWithValue("@APassword", apassword);
                    command.Parameters.AddWithValue("@APhone", aphone);
                    command.Parameters.AddWithValue("@AEmail", aemail);
                    command.Parameters.AddWithValue("@ASal", asal);
                    command.Parameters.AddWithValue("@APicture", aPicture);

                  
                    command.CommandText =
                     "INSERT into Admin (AId, AName, APassword, APhone, AEmail,  ASal ,APicture) values (@AId, @AName, @APassword, @APhone, @AEmail,  @ASal ,@APicture)";

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
    }
    }

