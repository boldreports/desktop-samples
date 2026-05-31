using System.Collections;
using System.Collections.Generic;

namespace LineChart
{
    public class ReportData
    {
        public class AdventureWorks
        {
            public string SalesPersonID { get; set; }
            public string FullName { get; set; }
            public string Title { get; set; }
            public string SalesTerritory { get; set; }
            public string Y2002 { get; set; }
            public string Y2003 { get; set; }
            public string Y2004 { get; set; }
            public string LastModifiedOn { get; set; }

            public static IList GetData()
            {
                List<AdventureWorks> AdventureWorksCollection = new List<AdventureWorks>();
                AdventureWorks AdventureWork = null;
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "280",
                    FullName = "Pamela",
                    Title = "Sales Representative",
                    SalesTerritory = "Northwest",
                    Y2002 = "1473076.9138",
                    Y2003 = "900368.5797",
                    Y2004 = "1656492.8626",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "281",
                    FullName = "Shu",
                    Title = "Sales Representative",
                    SalesTerritory = "Southwest",
                    Y2002 = "1",
                    Y2003 = "2870320.8578",
                    Y2004 = "3018725.4858",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "282",
                    FullName = "José",
                    Title = "Sales Representative",
                    SalesTerritory = "Canada",
                    Y2002 = "2532500.9127",
                    Y2003 = "1488793.3386",
                    Y2004 = "3189356.2465",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "283",
                    FullName = "David",
                    Title = "Sales Representative",
                    SalesTerritory = "Northwest",
                    Y2002 = "1243580.7691",
                    Y2003 = "1377431.3288",
                    Y2004 = "1930885.5631",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "287",
                    FullName = "Tete",
                    Title = "Sales Representative",
                    SalesTerritory = "Northwest",
                    Y2002 = "1",
                    Y2003 = "883338.7107",
                    Y2004 = "1931620.1835",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "275",
                    FullName = "Michael",
                    Title = "Sales Representative",
                    SalesTerritory = "Northeast",
                    Y2002 = "1951086.8256",
                    Y2003 = "4743906.8935",
                    Y2004 = "4557045.0459",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "276",
                    FullName = "Linda",
                    Title = "Sales Representative",
                    SalesTerritory = "Southwest",
                    Y2002 = "2800029.1538",
                    Y2003 = "4647225.4431",
                    Y2004 = "5200475.2311",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "277",
                    FullName = "Jillian",
                    Title = "Sales Representative",
                    SalesTerritory = "Central",
                    Y2002 = "3308895.8507",
                    Y2003 = "4991867.7074",
                    Y2004 = "3857163.6331",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "278",
                    FullName = "Vargas",
                    Title = "Sales Representative",
                    SalesTerritory = "Canada",
                    Y2002 = "1135639.2632",
                    Y2003 = "1480136.0065",
                    Y2004 = "1764938.9857",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                AdventureWork = new AdventureWorks()
                {
                    SalesPersonID = "279",
                    FullName = "Reiter",
                    Title = "Sales Representative",
                    SalesTerritory = "Southeast",
                    Y2002 = "3242697.0127",
                    Y2003 = "2661156.2418",
                    Y2004 = "2811012.7150",
                    LastModifiedOn = "1999-01-13T00:00:00"
                };
                AdventureWorksCollection.Add(AdventureWork);
                return AdventureWorksCollection;
            }
        }
    }
}
