
using BoldReports.UI.Xaml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QueryParameter
{
    public class ReportData
    {
        public static IList<ReportParameter> GetParameter()
        {
            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter param = new ReportParameter();
            param.Labels.Add("10248");
            param.Values.Add("10248");
            param.Name = "InvoiceID";
            parameters.Add(param);
            return parameters;
        }

        public class ShipDetails
        {
            public string ShipName { get; set; }
            public string ShipAddress { get; set; }
            public double Freight { get; set; }
            public DateTime ShippedDate { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }
            public string OrderID { get; set; }

            public static IList GetData(string orderId)
            {
                List<ShipDetails> ShipDetailsCollection = new List<ShipDetails>();
                ShipDetails shipDetail = null;

                shipDetail = new ShipDetails()
                {
                    ShipName = "Vins Chevalier",
                    ShipAddress = "59 rue de l'Abbaye",
                    Freight = 32.38,
                    ShippedDate = new DateTime(2003, 12, 23),
                    ShipCity = "Reims",
                    ShipCountry = "France",
                    OrderID = "10248"
                };

                ShipDetailsCollection.Add(shipDetail);

                shipDetail = new ShipDetails()
                {
                    ShipName = "Vins",
                    ShipAddress = "59 rue",
                    Freight = 32.38,
                    ShippedDate = new DateTime(2003, 12, 23),
                    ShipCity = "Reims",
                    ShipCountry = "France",
                    OrderID = "10249"
                };

                ShipDetailsCollection.Add(shipDetail);

                return ShipDetailsCollection.Where(sd => sd.OrderID.Equals(orderId)).ToList();
            }
        }

        public class InvoiceDetails
        {
            public string OrderID { get; set; }

            public static IList GetData(string orderId)
            {
                List<InvoiceDetails> invoiceDetailsCollection = new List<InvoiceDetails>();
                InvoiceDetails invoiceDetail = null;

                invoiceDetail = new InvoiceDetails()
                {
                    OrderID = "10248",

                };

                invoiceDetailsCollection.Add(invoiceDetail);

                invoiceDetail = new InvoiceDetails()
                {
                    OrderID = "10249",
                };

                invoiceDetailsCollection.Add(invoiceDetail);
                return invoiceDetailsCollection;
            }
        }

        public class OrderDetails
        {
            public string ProductID { get; set; }
            public string ProductName { get; set; }
            public string Quantity { get; set; }
            public double UnitPrice { get; set; }
            public double Discount { get; set; }
            public string OrderID { get; set; }
            public double Price
            {
                get
                {
                    return (UnitPrice * double.Parse(Quantity));
                }
            }

            public static IList GetData(string orderId)
            {
                List<OrderDetails> OrderDetailsCollection = new List<OrderDetails>();
                OrderDetails orderDetail = null;

                orderDetail = new OrderDetails()
                {
                    ProductID = "11",
                    Quantity = "12",
                    UnitPrice = 14,
                    Discount = 0,
                    OrderID = "10248",
                    ProductName = "Queso Cabrales"

                };

                OrderDetailsCollection.Add(orderDetail);

                orderDetail = new OrderDetails()
                {
                    ProductID = "42",
                    Quantity = "10",
                    UnitPrice = 9.8,
                    Discount = 0,
                    OrderID = "10248",
                    ProductName = "Mozzarella di Giovanni"
                };

                OrderDetailsCollection.Add(orderDetail);

                orderDetail = new OrderDetails()
                {
                    ProductID = "72",
                    Quantity = "5",
                    UnitPrice = 34.8,
                    Discount = 0,
                    OrderID = "10248",
                    ProductName = "Singaporean Hokkien Fried Mee"
                };

                OrderDetailsCollection.Add(orderDetail);

                orderDetail = new OrderDetails()
                {
                    ProductID = "72",
                    Quantity = "5",
                    UnitPrice = 34.8,
                    Discount = 0,
                    OrderID = "10249",
                    ProductName = "Singaporean"
                };

                OrderDetailsCollection.Add(orderDetail);
                return OrderDetailsCollection.Where(od => od.OrderID.Equals(orderId)).ToList();
            }
        }
    }
}
