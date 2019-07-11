using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace Application_layer
{
    public partial class ViewSaleItems : Form
    {
        public ViewSaleItems(int SaleID)
        {
            InitializeComponent();
            this.SaleID = SaleID;
        }


        int SaleID = 0;

        private void ViewSaleItems_Load(object sender, EventArgs e)
        {
            FoodRepository _DataAccess = new FoodRepository();

            foreach (Food SaleItemsDetails in _DataAccess.RetreiveSaleItems(SaleID))
            {
                SaleItemsGridView.Rows.Add(SaleItemsDetails.FName, SaleItemsDetails.FPrice, SaleItemsDetails.FQuantity, SaleItemsDetails.Total);
            }
        }
    }
}
