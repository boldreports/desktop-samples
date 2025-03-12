using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConditionalParameter
{
    public class ReportData
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        public double ExtPrice { get; set; }

        public static IList GetOrderSummary()
        {
            string[] prodcutName = new string[] { "Mountain-100 Black, 42", "Mountain-100 Black, 44", "Mountain-100 Black, 48", "Mountain-100 Silver, 38", "Long-Sleeve Logo Jersey, M", "Mountain Bike Socks, M", "Long-Sleeve Logo Jersey, L", "Road-450 Red, 52" };
            double[] prodcutPrice = new double[] { 10, 10.5, 15.25, 25, 10.25, 13, 20, 9.25 };
            List<ReportData> OrderSummaryCollection = new List<ReportData>();
            ReportData orderDetail = null;
            Random ran = new Random();
            int orderNumber = 43659;
            int prodcutCount = prodcutName.Count();

            for (int i = 0; i < 100; i++)
            {
                int prodcutIndex = ran.Next(prodcutCount);

                orderDetail = new ReportData()
                {
                    OrderId = orderNumber++,
                    OrderDate = new DateTime(ran.Next(2004, 2010), ran.Next(1, 12), ran.Next(1, 27)),
                    ProductName = prodcutName[prodcutIndex],
                    Quantity = ran.Next(1, 8),
                    UnitPrice = prodcutPrice[prodcutIndex],
                    Discount = 0.0000
                };

                orderDetail.ExtPrice = orderDetail.Quantity * orderDetail.UnitPrice;
                OrderSummaryCollection.Add(orderDetail);
            }

            return OrderSummaryCollection;
        }
    }
}