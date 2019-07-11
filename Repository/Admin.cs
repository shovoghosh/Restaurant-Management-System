using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Admin
    {

        private string aName;
        private string aId;
        private string aEmail;
        private string aPhone;
        private string aPassword;
        private double aSal;
        private byte[] aPicture;

        public string AName
        {
            get { return aName; }
            set { aName = value; }
        }

        public string AId
        {
            get { return aId; }
            set { aId = value; }
        }

        public string AEmail
        {
            get { return aEmail; }
            set { aEmail = value; }
        }

        public string APhone
        {
            get { return aPhone; }
            set { aPhone = value; }
        }


        public string APassword
        {
            get { return aPassword; }
            set { aPassword = value; }
        }

        public double ASal
        {
            get { return aSal; }
            set { aSal = value; }
        }


        public byte[] APicture
        {
            get { return aPicture; }
            set { aPicture = value; }
        }

    }
}
