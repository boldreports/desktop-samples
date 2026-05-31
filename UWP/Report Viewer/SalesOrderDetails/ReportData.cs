using BoldReports.UI.Xaml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SalesOrderDetails
{
    public class ReportData
    {
        public static IList<ReportParameter> GetParameters()
        {
            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter param = new ReportParameter();
            param.Labels.Add("SO50750");
            param.Values.Add("SO50750");
            param.Name = "SalesOrderNumber";
            parameters.Add(param);
            return parameters;
        }

        public class SalesOrder
        {
            public string SalesOrderNumber { get; set; }
            public string Store { get; set; }
            public string OrderDate { get; set; }
            public string SalesFirstName { get; set; }
            public string SalesLastName { get; set; }
            public string SalesTitle { get; set; }
            public string PurchaseOrderNumber { get; set; }
            public string ShipMethod { get; set; }
            public string BillAddress1 { get; set; }
            public string BillCity { get; set; }
            public string BillPostalCode { get; set; }
            public string BillStateProvince { get; set; }
            public string BillCountryRegion { get; set; }
            public string ShipAddress1 { get; set; }
            public string ShipCity { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipStateProvince { get; set; }
            public string ShipCountryRegion { get; set; }
            public string CustPhone { get; set; }
            public string CustFirstName { get; set; }
            public string CustLastName { get; set; }
            public static IList GetsalesOrderDetail(string salesOrderId)
            {
                List<SalesOrder> SalesOrderCollection = new List<SalesOrder>();
                SalesOrder salesOrder = null;
                salesOrder = new SalesOrder()
                {
                    SalesOrderNumber = "SO50750",
                    Store = "Central Discount Store",
                    OrderDate = "2003-06-01T00:00:00-04:00",
                    SalesFirstName = "David",
                    SalesLastName = "Campbell",
                    SalesTitle = "Sales Representative",
                    PurchaseOrderNumber = "PO7192170677",
                    ShipMethod = "CARGO TRANSPORT 5",
                    BillAddress1 = "259826 Russell Rd. South",
                    BillCity = "Kent",
                    BillPostalCode = "98031",
                    BillStateProvince = "Washington",
                    BillCountryRegion = "United States",
                    ShipAddress1 = "259826 Russell Rd. South",
                    ShipCity = "Kent",
                    ShipPostalCode = "98031",
                    ShipStateProvince = "Washington",
                    ShipCountryRegion = "United States",
                    CustPhone = "582-555-0113",
                    CustFirstName = "Jean",
                    CustLastName = "Handley"
                };
                SalesOrderCollection.Add(salesOrder);

                salesOrder = new SalesOrder()
                {
                    SalesOrderNumber = "SO50751",
                    Store = "Responsible Bike Dealers",
                    OrderDate = "2003-06-01T00:00:00-04:00",
                    SalesFirstName = "Michael",
                    SalesLastName = "Blythe",
                    SalesTitle = "Sales Representative",
                    PurchaseOrderNumber = "PO7018191419",
                    ShipMethod = "CARGO TRANSPORT 5",
                    BillAddress1 = "Ward Parkway Center",
                    BillCity = "Kansas City",
                    BillPostalCode = "64106",
                    BillStateProvince = "Missouri",
                    BillCountryRegion = "United States",
                    ShipAddress1 = "Ward Parkway Center",
                    ShipCity = "Kansas City",
                    ShipPostalCode = "64106",
                    ShipStateProvince = "Missouri",
                    ShipCountryRegion = "United States",
                    CustPhone = "620-555-0117",
                    CustFirstName = "Rob",
                    CustLastName = "Caron"
                };
                SalesOrderCollection.Add(salesOrder);
                return SalesOrderCollection.Where(soid => soid.SalesOrderNumber.Equals(salesOrderId)).ToList();
            }
        }
        public class SalesOrderDetail
        {
            public string SalesOrderDetailID { get; set; }
            public string OrderQty { get; set; }
            public double UnitPrice { get; set; }
            public string UnitPriceDiscount { get; set; }
            public double LineTotal { get; set; }
            public string CarrierTrackingNumber { get; set; }
            public string SalesOrderID { get; set; }
            public string Name { get; set; }
            public string ProductNumber { get; set; }
            public static IList GetsalesOrderDetail(string salesOrderId)
            {
                List<SalesOrderDetail> SalesOrderDetailCollection = new List<SalesOrderDetail>();
                SalesOrderDetail salesOrderDetail = null;
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35136",
                    OrderQty = "2",
                    UnitPrice = 5.1865,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 10.373000,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "AWC Logo Cap",
                    ProductNumber = "CA-1098"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35137",
                    OrderQty = "4",
                    UnitPrice = 22.7940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 91.176000,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "Full-Finger Gloves, M",
                    ProductNumber = "GL-F110-M"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35138",
                    OrderQty = "4",
                    UnitPrice = 28.8404,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 115.361600,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "Long-Sleeve Logo Jersey, L",
                    ProductNumber = "LJ-0192-L"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35139",
                    OrderQty = "3",
                    UnitPrice = 22.7940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 68.382000,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "Full-Finger Gloves, L",
                    ProductNumber = "GL-F110-L"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35140",
                    OrderQty = "1",
                    UnitPrice = 1229.4589,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 1229.458900,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "Mountain-200 Black, 42",
                    ProductNumber = "BK-M68B-42"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35141",
                    OrderQty = "1",
                    UnitPrice = 44.9940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 44.994000,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "Women's Tights, L",
                    ProductNumber = "TG-W091-L"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35142",
                    OrderQty = "1",
                    UnitPrice = 1242.8518,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 1242.851800,
                    CarrierTrackingNumber = "373D-417C-AE",
                    SalesOrderID = "50750",
                    Name = "Mountain-200 Silver, 38",
                    ProductNumber = "BK-M68S-38"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35143",
                    OrderQty = "2",
                    UnitPrice = 22.7940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 45.588000,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "Full-Finger Gloves, M",
                    ProductNumber = "GL-F110-M"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35144",
                    OrderQty = "6",
                    UnitPrice = 5.1865,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 31.119000,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "AWC Logo Cap",
                    ProductNumber = "CA-1098"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35145",
                    OrderQty = "1",
                    UnitPrice = 44.9940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 44.994000,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "Women's Tights, L",
                    ProductNumber = "TG-W091-L"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35146",
                    OrderQty = "3",
                    UnitPrice = 22.7940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 68.382000,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "Full-Finger Gloves, L",
                    ProductNumber = "GL-F110-L"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35147",
                    OrderQty = "1",
                    UnitPrice = 1229.4589,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 1229.458900,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "Mountain-200 Black, 38",
                    ProductNumber = "BK-M68B-38"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35148",
                    OrderQty = "2",
                    UnitPrice = 22.7940,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 45.588000,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "Full-Finger Gloves, S",
                    ProductNumber = "GL-F110-S"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                salesOrderDetail = new SalesOrderDetail()
                {
                    SalesOrderDetailID = "35149",
                    OrderQty = "1",
                    UnitPrice = 28.8404,
                    UnitPriceDiscount = "0.0000",
                    LineTotal = 28.840400,
                    CarrierTrackingNumber = "5750-45C6-9C",
                    SalesOrderID = "50751",
                    Name = "Long-Sleeve Logo Jersey, L",
                    ProductNumber = "LJ-0192-L"
                };
                SalesOrderDetailCollection.Add(salesOrderDetail);
                return SalesOrderDetailCollection.Where(soid => soid.SalesOrderID.Equals(salesOrderId)).ToList();
            }
        }

        public class SalesOrderNumbers
        {
            public string SalesOrderNumber { get; set; }
            public static IList GetSalesOrderNumbers()
            {
                List<SalesOrderNumbers> salesNumberCollection = new List<SalesOrderNumbers>();
                SalesOrderNumbers orderNumber = null;
                orderNumber = new SalesOrderNumbers()
                {
                    SalesOrderNumber = "SO50750"
                };
                salesNumberCollection.Add(orderNumber);
                orderNumber = new SalesOrderNumbers()
                {
                    SalesOrderNumber = "SO50751"
                };
                salesNumberCollection.Add(orderNumber);
                return salesNumberCollection;
            }
        }
    }
}
