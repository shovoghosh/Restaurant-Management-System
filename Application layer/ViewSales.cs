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
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
        }



        private void ViewSales_Load(object sender, EventArgs e)
        {
            FoodRepository _DataAccess = new FoodRepository();

            foreach (Food SaleDetails in _DataAccess.RetreiveAllSales())
            {
                SalesGridView.Rows.Add(SaleDetails.SaleID, SaleDetails.SaleTime, SaleDetails.FName, SaleDetails.Total, "View Products");
            }

        }

        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SalesGridView.Columns[e.ColumnIndex].Name == "ProductsColumn")
                {
                    int SaleID = Convert.ToInt32(SalesGridView.Rows[e.RowIndex].Cells["SaleIDColumn"].Value);

                    ViewSaleItems _ViewSaleItems = new ViewSaleItems(SaleID);

                    _ViewSaleItems.ShowDialog();
                }
            }
        }



    }
}
