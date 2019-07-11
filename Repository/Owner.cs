using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class Owner
    {

        private string oName;
        private string oId;
        private string oPassword;
        private string oEmail;
        private string oPhone;
        
        public string OName
        {
            get { return oName; }
            set { oName = value; }
        }

        public string OId
        {
            get { return oId; }
            set { oId = value; }
        }

        public string OPassword
        {
            get { return oPassword; }
            set { oPassword = value; }
        }

        public string OEmail
        {
            get { return oEmail; }
            set { oEmail = value; }
        }

        public string OPhone
        {
            get { return oPhone; }
            set { oPhone = value; }
        }
    }
}
