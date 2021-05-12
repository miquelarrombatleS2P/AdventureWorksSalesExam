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
    public partial class MainForm : Form
    {
        string customerId;
        SalesOrderHeader salesOrder;
        public MainForm()
        {
            InitializeComponent();
            inicializeCusotmersComboBox();
        }

        private void inicializeCusotmersComboBox()
        {
            List<Customer> custumers = DataAccess.GetCustomers();
            foreach (Customer item in custumers)
            {
                customerId = item.CustomerID.ToString();
                customersComboBox.Items.Add(item.CustomerID + " : " + item.FirstName+" "+item.LastName);
            }
        }
        

        private void salesListBox_DoubleClick(object sender, EventArgs e)
        {
            string salesSelected = salesListBox.SelectedItems[0].ToString();

            SalesOrderHeader sales = new SalesOrderHeader();

            string salesIString = salesSelected.Split(',')[0];
            string[] salesID = salesIString.Split(':');
            sales.SalesOrderID = int.Parse(salesID[1]);

            string dateString = salesSelected.Split(',')[1];
            string[] dateSale = dateString.Split(':');
            sales.OrderDate = DateTime.Parse(dateSale[1]);

            string SubTotalString = salesSelected.Split(',')[3];
            string[] SubTotalSale = SubTotalString.Split(':');
            sales.Subtotal = decimal.Parse(SubTotalSale[1]);

            string taxString = salesSelected.Split(',')[4];
            string[] TaxSale = taxString.Split(':');
            sales.TaxAmt = decimal.Parse(TaxSale[1].ToString());

            string ShippingString = salesSelected.Split(',')[5];
            string[] ShippingSale = ShippingString.Split(':');
            sales.Freight = decimal.Parse(ShippingSale[1].ToString());

            string totalString = salesSelected.Split(',')[6];
            string[] totalSale = totalString.Split(':');
            sales.TotalDue = decimal.Parse(totalSale[1].ToString());

            DetallForm salesDetails = new DetallForm(customerId, sales);
            salesDetails.ShowDialog();

        }

        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            salesListBox.Items.Clear();
            ComboBox comboBox = sender as ComboBox;
            string[] customer = comboBox.Text.ToString().Split(':');
            //string[] customer = customersComboBox.Text.Split(':');
            string customID = customer[0];
            int customerID = int.Parse(customID);
                        
            List<SalesOrderHeader> salesOrderHeader = DataAccess.GetOrderHeader(customerID);
            foreach (SalesOrderHeader item in salesOrderHeader)
            {
                salesListBox.Items.Add(item.ToString());
            }
        }
    }
}
