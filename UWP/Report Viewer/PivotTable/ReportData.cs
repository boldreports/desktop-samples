using System.Collections;
using System.Collections.Generic;

namespace PivotTable
{
    public class ReportData
    {
            public string ProdCat { get; set; }
            public string SubCat { get; set; }
            public string OrderYear { get; set; }
            public string OrderQtr { get; set; }
            public double Sales { get; set; }
            public static IList GetData()
            {
                List<ReportData> ReportDataCollection = new List<ReportData>();
                ReportData AdventureWork = null;
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Helmets",
                    OrderYear = "2002",
                    OrderQtr = "Q1",
                    Sales = 4945.6925
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Road Frames",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 957715.1942
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Forks",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 23543.1060
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2002",
                    OrderQtr = "Q1",
                    Sales = 3171787.6112
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Helmets",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 33853.1033
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Wheels",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 163921.8870
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 4119658.6506
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Socks",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 6968.6884
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 3734891.6389
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Mountain Frames",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 608352.8754
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Handlebars",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 18309.4452
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Road Frames",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 286591.8208
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Tires and Tubes",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 41940.3364
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Mountain Frames",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 440260.9831
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Road Frames",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 457688.8401
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Vests",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 66882.6450
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Pumps",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 3226.3860
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Tights",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 51600.6190
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Chains",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 3476.0176
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Handlebars",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 17194.2146
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Mountain Frames",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 565229.8810
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Tights",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 243.7175
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Road Frames",
                    OrderYear = "2002",
                    OrderQtr = "Q2",
                    Sales = 155311.4063
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Mountain Frames",
                    OrderYear = "2002",
                    OrderQtr = "Q2",
                    Sales = 220935.1648
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Locks",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 15.0000
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Mountain Frames",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 827287.5234
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Bike Racks",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 75920.4000
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Bottom Brackets",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 17453.6400
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Touring Bikes",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 3298006.2858
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Brakes",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 18571.4700
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Tights",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 56782.4280
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Pedals",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 54185.2014
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Jerseys",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 173041.0492
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Jerseys",
                    OrderYear = "2002",
                    OrderQtr = "Q2",
                    Sales = 16931.2362
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Headsets",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 19701.9001
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Road Frames",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 458089.4246
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Shorts",
                    OrderYear = "2003",
                    OrderQtr = "Q1",
                    Sales = 11230.1280
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2002",
                    OrderQtr = "Q4",
                    Sales = 4189621.8590
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Brakes",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 26659.0800
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Wheels",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 83.2981
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Vests",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 81085.6900
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Cranksets",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 80244.1372
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Socks",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 6183.1422
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Wheels",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 163929.9435
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Tights",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 67088.3037
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Tights",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 779.8960
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Socks",
                    OrderYear = "2002",
                    OrderQtr = "Q1",
                    Sales = 1273.8550
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 4930692.7825
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Shorts",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 84192.3708
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Jerseys",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 48901.7598
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Shorts",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 26207.2314
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2002",
                    OrderQtr = "Q2",
                    Sales = 3478963.5378
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Shorts",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 21423.6288
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Derailleurs",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 25385.2550
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Handlebars",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 21675.6840
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Bottom Brackets",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 13339.1820
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Clothing",
                    SubCat = "Jerseys",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 31334.6088
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Helmets",
                    OrderYear = "2002",
                    OrderQtr = "Q2",
                    Sales = 11638.8628
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Headsets",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 14102.2548
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Handlebars",
                    OrderYear = "2002",
                    OrderQtr = "Q3",
                    Sales = 35341.0863
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Touring Bikes",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 3766585.3623
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Chains",
                    OrderYear = "2003",
                    OrderQtr = "Q4",
                    Sales = 2217.8992
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Accessories",
                    SubCat = "Locks",
                    OrderYear = "2003",
                    OrderQtr = "Q2",
                    Sales = 3939.0000
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Bikes",
                    SubCat = "Road Bikes",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 3844123.5588
                };
                ReportDataCollection.Add(AdventureWork);
                AdventureWork = new ReportData()
                {
                    ProdCat = "Components",
                    SubCat = "Handlebars",
                    OrderYear = "2003",
                    OrderQtr = "Q3",
                    Sales = 43624.0992
                };
                ReportDataCollection.Add(AdventureWork);
                return ReportDataCollection;
            }
    }
}
