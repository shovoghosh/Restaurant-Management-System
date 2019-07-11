using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Customer
    {

        private string cName;
        private string cId;
        private string cPassword;
        private string cEmail;
        private string cPhone;
        private byte[] cPicture;

        public byte[] CPicture
        {
            get { return cPicture; }
            set { cPicture = value; }
        }

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }

        public string CId
        {
            get { return cId; }
            set { cId = value; }
        }

        public string CPassword
        {
            get { return cPassword; }
            set { cPassword = value; }
        }

        public string CEmail
        {
            get { return cEmail; }
            set { cEmail = value; }
        }

        public string CPhone
        {
            get { return cPhone; }
            set { cPhone = value; }
        }
    }
}
