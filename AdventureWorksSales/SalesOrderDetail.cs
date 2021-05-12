namespace AdventureWorksSales
{
    public class SalesOrderDetail
    {
        public int SalesOrderDetailID { get; set; }
        public int OrderQty { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }

        public override string ToString()
        {
            return "Qty:" + OrderQty + "         Prdouct:" + ProductName + "                             Unit Price:" + UnitPrice.ToString("C2") + "                  LineTotal:" + LineTotal.ToString("C2");
        }
    }
}