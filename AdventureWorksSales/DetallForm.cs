using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksSales
{
    public partial class DetallForm : Form
    {
        public DetallForm(string customerId, SalesOrderHeader salesOrder)
        {
            InitializeComponent();
            infoSalesOrder(customerId, salesOrder);
            inicializeInfoListBox(salesOrder.SalesOrderID);

        }
        private void infoSalesOrder(string customerId, SalesOrderHeader salesOrder)
        {
            customerTextBox.Text = customerId;
            dateTextBox.Text = salesOrder.OrderDate.ToString();
            orderNumberTextBox.Text = salesOrder.SalesOrderID.ToString();
            SubtotaltextBox.Text = salesOrder.Subtotal.ToString("C2");
            TaxtextBox.Text = salesOrder.TaxAmt.ToString("C2");
            ShippingtextBox.Text = salesOrder.Freight.ToString("C2");
            totaltextBox.Text = salesOrder.TotalDue.ToString("C2");

        }

        private void inicializeInfoListBox(int salesID)
        {
            List<SalesOrderDetail> orderDetail = DataAccess.GetOrderDetails(salesID);
            foreach (SalesOrderDetail item in orderDetail)
            {
                detailsInfoListBox.Items.Add(item.ToString());
            }
        }

        private void detailsInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
