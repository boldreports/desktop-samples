
using BoldReports.UI.Xaml;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesDashboard
{
    public class ReportData
    {

        public static IList<ReportParameter> GetParameters()
        {
            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter param = new ReportParameter();
            param.Labels.Add("2001");
            param.Values.Add("2001");
            param.Name = "SalesYearParameter";
            parameters.Add(param);
            return parameters;
        }
        public class SalesPersons
        {
            public string Name { get; set; }
            public double QS1 { get; set; }
            public double QS2 { get; set; }
            public double QS3 { get; set; }
            public double QS4 { get; set; }
            public double Total { get; set; }
            public int Year { get; set; }
            public static IList GetTopSalesPerson(int year)
            {
                List<SalesPersons> SalesPersonCollection = new List<SalesPersons>();
                SalesPersons salesPerson = null;
                salesPerson = new SalesPersons()
                {
                    Name = "Carol Elliott",
                    QS3 = 656287.9884,
                    QS4 = 1006810.7219,
                    Total = 1663098.7103,
                    Year = 2001
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Linda Ecoffey",
                    QS3 = 547589.0181,
                    QS4 = 951811.3768,
                    Total = 1499400.3949,
                    Year = 2001
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Shelley Dyck",
                    QS3 = 551800.5660,
                    QS4 = 823059.5628,
                    Total = 1374860.1288,
                    Year = 2001
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Michael Emanuel",
                    QS3 = 515235.5282,
                    QS4 = 733617.1174,
                    Total = 1248852.6456,
                    Year = 2001
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Jauna Elson",
                    QS3 = 453982.3228,
                    QS4 = 614458.9850,
                    Total = 1068441.3078,
                    Year = 2001
                };
                SalesPersonCollection.Add(salesPerson);

                salesPerson = new SalesPersons()
                {
                    Name = "Linda Ecoffey",
                    QS1 = 781351.2313,
                    QS2 = 1028144.2245,
                    QS3 = 1531824.7788,
                    QS4 = 1263787.6537,
                    Total = 4605107.8883,
                    Year = 2002
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Shelley Dyck",
                    QS1 = 710292.4523,
                    QS2 = 714876.5727,
                    QS3 = 1415932.4341,
                    QS4 = 1142145.8485,
                    Total = 3983247.3076,
                    Year = 2002
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Maciej Dusza",
                    QS1 = 489810.4459,
                    QS2 = 558046.5501,
                    QS3 = 1516710.9716,
                    QS4 = 1179535.1114,
                    Total = 3744103.0790,
                    Year = 2002
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Gail Erickson",
                    QS1 = 0,
                    QS2 = 0,
                    QS3 = 1739975.7306,
                    QS4 = 1306538.9169,
                    Total = 3046514.6475,
                    Year = 2002
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Carol Elliott",
                    QS1 = 744774.7917,
                    QS2 = 834823.5107,
                    QS3 = 812349.5603,
                    QS4 = 653131.5843,
                    Total = 3045079.4470,
                    Year = 2002
                };
                SalesPersonCollection.Add(salesPerson);

                salesPerson = new SalesPersons()
                {
                    Name = "Gail Erickson",
                    QS1 = 981735.7977,
                    QS2 = 1258793.8673,
                    QS3 = 1476692.0028,
                    QS4 = 1356994.7597,
                    Total = 5074216.4275,
                    Year = 2003
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Shelley Dyck",
                    QS1 = 925501.3401,
                    QS2 = 1163645.8204,
                    QS3 = 1622531.0508,
                    QS4 = 1284147.5293,
                    Total = 4995825.740,
                    Year = 2003
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Maciej Dusza",
                    QS1 = 820852.0529,
                    QS2 = 1226808.7576,
                    QS3 = 1497942.9170,
                    QS4 = 1200475.2000,
                    Total = 4746078.9275,
                    Year = 2003
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Linda Ecoffey",
                    QS1 = 917504.6713,
                    QS2 = 1278750.6036,
                    QS3 = 1252426.1780,
                    QS4 = 953423.5345,
                    Total = 4402104.9874,
                    Year = 2003
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Jauna Elson",
                    QS1 = 524679.7564,
                    QS2 = 626051.3386,
                    QS3 = 948047.6240,
                    QS4 = 777144.9274,
                    Total = 2875923.6464,
                    Year = 2003
                };
                SalesPersonCollection.Add(salesPerson);

                salesPerson = new SalesPersons()
                {
                    Name = "Shelley Dyck",
                    QS1 = 1026805.5472,
                    QS2 = 1266991.1038,
                    Total = 2293796.6510,
                    Year = 2004
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Gail Erickson",
                    QS1 = 934697.3750,
                    QS2 = 1247298.2376,
                    Total = 2181995.6126,
                    Year = 2004
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Maciej Dusza",
                    QS1 = 875242.441,
                    QS2 = 983384.4873,
                    Total = 1858626.9289,
                    Year = 2004
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Mark Erickson",
                    QS1 = 715362.2737,
                    QS2 = 943155.7965,
                    Total = 1658518.0702,
                    Year = 2004
                };
                SalesPersonCollection.Add(salesPerson);
                salesPerson = new SalesPersons()
                {
                    Name = "Linda Ecoffey",
                    QS1 = 731927.6488,
                    QS2 = 919386.2718,
                    Total = 1651313.9206,
                    Year = 2004
                };
                SalesPersonCollection.Add(salesPerson);

                return SalesPersonCollection.Where(spc => spc.Year == year).ToList();
            }
        }

        public class Stores
        {
            public string Name { get; set; }
            public double QS1 { get; set; }
            public double QS2 { get; set; }
            public double QS3 { get; set; }
            public double QS4 { get; set; }
            public double Total { get; set; }
            public int year { get; set; }
            public static IList GetTopStores(int year)
            {
                List<Stores> StoreCollection = new List<Stores>();
                Stores store = null;
                store = new Stores()
                {
                    Name = "Bicycle Company",
                    QS3 = 656287.9884,
                    QS4 = 1006810.7219,
                    Total = 1663098.7103,
                    year = 2001
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Activity Center",
                    QS3 = 656287.9884,
                    QS4 = 1006810.7219,
                    Total = 1663098.7103,
                    year = 2001
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Bike Shop",
                    QS3 = 656287.9884,
                    QS4 = 1006810.7219,
                    Total = 1663098.7103,
                    year = 2001
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Bike Goods ",
                    QS3 = 656287.9884,
                    QS4 = 1006810.7219,
                    Total = 1663098.7103,
                    year = 2001
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Bike Rims",
                    QS3 = 656287.9884,
                    QS4 = 1006810.7219,
                    Total = 1663098.7103,
                    year = 2001
                };
                StoreCollection.Add(store);

                store = new Stores()
                {
                    Name = "Great Bicycle",
                    QS1 = 781351.2313,
                    QS2 = 1028144.2245,
                    QS3 = 1531824.7788,
                    QS4 = 1263787.6537,
                    Total = 4605107.8883,
                    year = 2002
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Bike Shop",
                    QS1 = 781351.2313,
                    QS2 = 1028144.2245,
                    QS3 = 1531824.7788,
                    QS4 = 1263787.6537,
                    Total = 4605107.8883,
                    year = 2002
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Active Systems",
                    QS1 = 781351.2313,
                    QS2 = 1028144.2245,
                    QS3 = 1531824.7788,
                    QS4 = 1263787.6537,
                    Total = 4605107.8883,
                    year = 2002
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Advanced Bike",
                    QS1 = 781351.2313,
                    QS2 = 1028144.2245,
                    QS3 = 1531824.7788,
                    QS4 = 1263787.6537,
                    Total = 4605107.8883,
                    year = 2002
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Seasons Sports",
                    QS1 = 781351.2313,
                    QS2 = 1028144.2245,
                    QS3 = 1531824.7788,
                    QS4 = 1263787.6537,
                    Total = 4605107.8883,
                    year = 2002
                };
                StoreCollection.Add(store);

                store = new Stores()
                {
                    Name = "Action Bicycle",
                    QS1 = 981735.7977,
                    QS2 = 1258793.8673,
                    QS3 = 1476692.0028,
                    QS4 = 1356994.7597,
                    Total = 5074216.4275,
                    year = 2003
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Area Sheet",
                    QS1 = 981735.7977,
                    QS2 = 1258793.8673,
                    QS3 = 1476692.0028,
                    QS4 = 1356994.7597,
                    Total = 5074216.4275,
                    year = 2003
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Authentic Sales",
                    QS1 = 981735.7977,
                    QS2 = 1258793.8673,
                    QS3 = 1476692.0028,
                    QS4 = 1356994.7597,
                    Total = 5074216.4275,
                    year = 2003
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Discount Stores",
                    QS1 = 981735.7977,
                    QS2 = 1258793.8673,
                    QS3 = 1476692.0028,
                    QS4 = 1356994.7597,
                    Total = 5074216.4275,
                    year = 2003
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Central Bicycle",
                    QS1 = 981735.7977,
                    QS2 = 1258793.8673,
                    QS3 = 1476692.0028,
                    QS4 = 1356994.7597,
                    Total = 5074216.4275,
                    year = 2003
                };
                StoreCollection.Add(store);

                store = new Stores()
                {
                    Name = "Aerobic Exercise",
                    QS1 = 1026805.5472,
                    QS2 = 1266991.1038,
                    Total = 2293796.6510,
                    year = 2004
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Alpine House",
                    QS1 = 1026805.5472,
                    QS2 = 1266991.1038,
                    Total = 2293796.6510,
                    year = 2004
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Sporting Goods",
                    QS1 = 1026805.5472,
                    QS2 = 1266991.1038,
                    Total = 2293796.6510,
                    year = 2004
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Basic Sports",
                    QS1 = 1026805.5472,
                    QS2 = 1266991.1038,
                    Total = 2293796.6510,
                    year = 2004
                };
                StoreCollection.Add(store);
                store = new Stores()
                {
                    Name = "Bold Bikes",
                    QS1 = 1026805.5472,
                    QS2 = 1266991.1038,
                    Total = 2293796.6510,
                    year = 2004
                };
                StoreCollection.Add(store);

                return StoreCollection.Where(sc => sc.year == year).ToList();
            }
        }

        public class Products
        {
            public string Name { get; set; }
            public double QS1 { get; set; }
            public double QS2 { get; set; }
            public double QS3 { get; set; }
            public double QS4 { get; set; }
            public double Total { get; set; }
            public int Year { get; set; }
            public static IList GetTopProducts(int year)
            {
                List<Products> ProductCollection = new List<Products>();
                Products product = null;
                product = new Products()
                {
                    Name = "AWC Logo Cap",
                    QS3 = 2104165.3554,
                    QS4 = 3308323.5938,
                    Total = 5412488.9492,
                    Year = 2001
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, B",
                    QS3 = 1988382.4844,
                    QS4 = 3279281.6611,
                    Total = 5267664.1455,
                    Year = 2001
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "L-Sleeve Jrsey",
                    QS3 = 1974839.7878,
                    QS4 = 3282139.2608,
                    Total = 5256979.0486,
                    Year = 2001
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, R",
                    QS3 = 1971943.0387,
                    QS4 = 3140308.6115,
                    Total = 5112251.6502,
                    Year = 2001
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, Bk",
                    QS3 = 2008908.3029,
                    QS4 = 3096292.8994,
                    Total = 5105201.2023,
                    Year = 2001
                };
                ProductCollection.Add(product);

                product = new Products()
                {
                    Name = "AWC Logo Cap",
                    QS1 = 2479585.3057,
                    QS2 = 3246499.0536,
                    QS3 = 6803560.4591,
                    QS4 = 5176061.7865,
                    Total = 17705706.6049,
                    Year = 2002
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "L-Sleeve Jersey",
                    QS1 = 2506478.8038,
                    QS2 = 3451364.1049,
                    QS3 = 6640485.7449,
                    QS4 = 5081732.7792,
                    Total = 17680061.4328,
                    Year = 2002
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, B",
                    QS1 = 1591213.0306,
                    QS2 = 3019373.2897,
                    QS3 = 6681639.5312,
                    QS4 = 4970609.3327,
                    Total = 16262835.1842,
                    Year = 2002
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, R",
                    QS1 = 1200410.2689,
                    QS2 = 2986523.1779,
                    QS3 = 6704405.3528,
                    QS4 = 4796516.5549,
                    Total = 15687855.3545,
                    Year = 2002
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, Bk",
                    QS1 = 1326226.1287,
                    QS2 = 2785577.5765,
                    QS3 = 6702788.2116,
                    QS4 = 4830625.4549,
                    Total = 15645217.3717,
                    Year = 2002
                };
                ProductCollection.Add(product);

                product = new Products()
                {
                    Name = "AWC Logo Cap",
                    QS1 = 3767204.2532,
                    QS2 = 5144768.8936,
                    QS3 = 6850399.6554,
                    QS4 = 5329958.1031,
                    Total = 21092330.9053,
                    Year = 2003
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "L-Sleeve Jersey",
                    QS1 = 3718432.7781,
                    QS2 = 5082651.5234,
                    QS3 = 6479515.2897,
                    QS4 = 4995648.8312,
                    Total = 20276248.4224,
                    Year = 2003
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, B",
                    QS1 = 3001922.0189,
                    QS2 = 4938119.6587,
                    QS3 = 6504481.8462,
                    QS4 = 5092806.3654,
                    Total = 19537329.8892,
                    Year = 2003
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, Bk",
                    QS1 = 2532321.1181,
                    QS2 = 4896278.2250,
                    QS3 = 6517251.1923,
                    QS4 = 5152659.6077,
                    Total = 19098510.1431,
                    Year = 2003
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, R",
                    QS1 = 1444428.4599,
                    QS2 = 5020718.6434,
                    QS3 = 6451496.9938,
                    QS4 = 5015496.1295,
                    Total = 17932140.2266,
                    Year = 2003
                };
                ProductCollection.Add(product);

                product = new Products()
                {
                    Name = "Water Bottle",
                    QS1 = 4121940.2137,
                    QS2 = 5866889.4854,
                    QS3 = 7450.1100,
                    Total = 9996279.8091,
                    Year = 2004
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "AWC Logo Cap",
                    QS1 = 3676842.2034,
                    QS2 = 5407113.3880,
                    QS3 = 5465.0800,
                    Total = 9089420.6714,
                    Year = 2004
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "Classic Vest, S",
                    QS1 = 3794769.6580,
                    QS2 = 4936799.8561,
                    QS3 = 979.0100,
                    Total = 8732548.5241,
                    Year = 2004
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-SC Jersey, XL",
                    QS1 = 3568526.5876,
                    QS2 = 5130984.2023,
                    QS3 = 1761.0300,
                    Total = 8701271.8199,
                    Year = 2004
                };
                ProductCollection.Add(product);
                product = new Products()
                {
                    Name = "S-100 Helmet, B",
                    QS1 = 3156520.2089,
                    QS2 = 5249154.4748,
                    QS3 = 6531.6000,
                    Total = 8412206.2837,
                    Year = 2004
                };
                ProductCollection.Add(product);

                return ProductCollection.Where(pc => pc.Year == year).ToList();
            }
        }
    }
}
