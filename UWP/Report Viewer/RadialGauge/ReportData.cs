using System.Collections;
using System.Collections.Generic;

namespace RadialGauge
{
    public class ReportData
    {
        public string Name { get; set; }
        public string OrderQty { get; set; }
        public string LineTotal { get; set; }
        public static IList GetData()
        {
            List<ReportData> SalesDetailsCollection = new List<ReportData>();
            ReportData SalesDetail = null;
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "4",
                LineTotal = "201.0400"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "135.3600"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "136.7415"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "550",
                LineTotal = "8847.3000"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "171.0765"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "550",
                LineTotal = "20397.3000"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "550",
                LineTotal = "14628.0750"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "550",
                LineTotal = "14882.1750"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "550",
                LineTotal = "18468.4500"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "550",
                LineTotal = "25334.9250"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "142.4115"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "136.1115"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "148.9320"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "136.1115"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "129.8115"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "142.5690"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "136.2690"
            };
            SalesDetailsCollection.Add(SalesDetail);
            SalesDetail = new ReportData()
            {
                Name = "International",
                OrderQty = "3",
                LineTotal = "149.0895"
            };
            SalesDetailsCollection.Add(SalesDetail);
            return SalesDetailsCollection;
        }
    }
}
