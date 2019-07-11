using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Food
    {

        private string fName;
        private int fId;
        private string fCategory;
        private decimal fPrice;
        private int fQuantity;
        private string fDescription;
        private byte[] fPicture;
        private byte[] cPicture;
        private decimal total;
        private int saleID;
        private DateTime saleTime;



        public DateTime SaleTime
        {
            get { return saleTime; }
            set { saleTime = value; }
        }

        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public byte[] FPicture
        {
            get { return fPicture; }
            set { fPicture = value; }
        }

        public byte[] CPicture
        {
            get { return cPicture; }
            set { cPicture = value; }
        }

        public string FDescription
        {
            get { return fDescription; }
            set { fDescription = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public int FId
        {
            get { return fId; }
            set { fId = value; }
        }

        public string FCategory
        {
            get { return fCategory; }
            set { fCategory = value; }
        }

        public decimal FPrice
        {
            get { return fPrice; }
            set { fPrice = value; }
        }

        public int FQuantity
        {
            get { return fQuantity; }
            set { fQuantity = value; }
        }
    }
}
