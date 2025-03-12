using System.Collections;
using System.Collections.Generic;

namespace ConditionalRowFormatting
{
    public class ReportData
    {
        public class CustomerDetails
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }

            public static IList GetData()
            {
                List<CustomerDetails> CustomerDetailsCollection = new List<CustomerDetails>();
                CustomerDetails CustomerDetail = null;
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "ALFKI",
                    CompanyName = "Alfreds Futterkiste",
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    PostalCode = "12209",
                    Country = "Germany"
                };

                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "ANATR",
                    CompanyName = "Ana Trujillo Emparedados y helados",
                    Address = "Avda. de la Constitución 2222",
                    City = "México D.F.",
                    PostalCode = "05021",
                    Country = "Mexico"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "ANTON",
                    CompanyName = "Antonio Moreno Taquería",
                    Address = "Mataderos  2312",
                    City = "México D.F.",
                    PostalCode = "05023",
                    Country = "Mexico"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "AROUT",
                    CompanyName = "Around the Horn",
                    Address = "120 Hanover Sq.",
                    City = "London",
                    PostalCode = "WA1 1DP",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BERGS",
                    CompanyName = "Berglunds snabbköp",
                    Address = "Berguvsvägen  8",
                    City = "Luleå",
                    PostalCode = "S-958 22",
                    Country = "Sweden"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BLAUS",
                    CompanyName = "Blauer See Delikatessen",
                    Address = "Forsterstr. 57",
                    City = "Mannheim",
                    PostalCode = "68306",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BLONP",
                    CompanyName = "Blondel père et fils",
                    Address = "24, place Kléber",
                    City = "Strasbourg",
                    PostalCode = "67000",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BOLID",
                    CompanyName = "Bólido Comidas preparadas",
                    Address = "C/ Araquil, 67",
                    City = "Madrid",
                    PostalCode = "28023",
                    Country = "Spain"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BONAP",
                    CompanyName = "Bon app'",
                    Address = "12, rue des Bouchers",
                    City = "Marseille",
                    PostalCode = "13008",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BOTTM",
                    CompanyName = "Bottom-Dollar Markets",
                    Address = "23 Tsawassen Blvd.",
                    City = "Tsawassen",
                    PostalCode = "T2F 8M4",
                    Country = "Canada"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "BSBEV",
                    CompanyName = "B's Beverages",
                    Address = "Fauntleroy Circus",
                    City = "London",
                    PostalCode = "EC2 5NT",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "CACTU",
                    CompanyName = "Cactus Comidas para llevar",
                    Address = "Cerrito 333",
                    City = "Buenos Aires",
                    PostalCode = "1010",
                    Country = "Argentina"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "CENTC",
                    CompanyName = "Centro comercial Moctezuma",
                    Address = "Sierras de Granada 9993",
                    City = "México D.F.",
                    PostalCode = "05022",
                    Country = "Mexico"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "CHOPS",
                    CompanyName = "Chop-suey Chinese",
                    Address = "Hauptstr. 29",
                    City = "Bern",
                    PostalCode = "3012",
                    Country = "Switzerland"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "COMMI",
                    CompanyName = "Comércio Mineiro",
                    Address = "Av. dos Lusíadas, 23",
                    City = "São Paulo",
                    PostalCode = "05432-043",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "CONSH",
                    CompanyName = "Consolidated Holdings",
                    Address = "Berkeley Gardens 12  Brewery ",
                    City = "London",
                    PostalCode = "WX1 6LT",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "DRACD",
                    CompanyName = "Drachenblut Delikatessen",
                    Address = "Walserweg 21",
                    City = "Aachen",
                    PostalCode = "52066",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "DUMON",
                    CompanyName = "Du monde entier",
                    Address = "67, rue des Cinquante Otages",
                    City = "Nantes",
                    PostalCode = "44000",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "EASTC",
                    CompanyName = "Eastern Connection",
                    Address = "35 King George",
                    City = "London",
                    PostalCode = "WX3 6FW",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "ERNSH",
                    CompanyName = "Ernst Handel",
                    Address = "Kirchgasse 6",
                    City = "Graz",
                    PostalCode = "8010",
                    Country = "Austria"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FAMIA",
                    CompanyName = "Familia Arquibaldo",
                    Address = "Rua Orós, 92",
                    City = "São Paulo",
                    PostalCode = "05442-030",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FISSA",
                    CompanyName = "FISSA Fabrica Inter. Salchichas S.A.",
                    Address = "C/ Moralzarzal, 86",
                    City = "Madrid",
                    PostalCode = "28034",
                    Country = "Spain"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FOLIG",
                    CompanyName = "Folies gourmandes",
                    Address = "184, chaussée de Tournai",
                    City = "Lille",
                    PostalCode = "59000",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FOLKO",
                    CompanyName = "Folk och fä HB",
                    Address = "Åkergatan 24",
                    City = "Bräcke",
                    PostalCode = "S-844 67",
                    Country = "Sweden"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FRANK",
                    CompanyName = "Frankenversand",
                    Address = "Berliner Platz 43",
                    City = "München",
                    PostalCode = "80805",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FRANR",
                    CompanyName = "France restauration",
                    Address = "54, rue Royale",
                    City = "Nantes",
                    PostalCode = "44000",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FRANS",
                    CompanyName = "Franchi S.p.A.",
                    Address = "Via Monte Bianco 34",
                    City = "Torino",
                    PostalCode = "10100",
                    Country = "Italy"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "FURIB",
                    CompanyName = "Furia Bacalhau e Frutos do Mar",
                    Address = "Jardim das rosas n. 32",
                    City = "Lisboa",
                    PostalCode = "1675",
                    Country = "Portugal"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "GALED",
                    CompanyName = "Galería del gastrónomo",
                    Address = "Rambla de Cataluña, 23",
                    City = "Barcelona",
                    PostalCode = "08022",
                    Country = "Spain"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "GODOS",
                    CompanyName = "Godos Cocina Típica",
                    Address = "C/ Romero, 33",
                    City = "Sevilla",
                    PostalCode = "41101",
                    Country = "Spain"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "GOURL",
                    CompanyName = "Gourmet Lanchonetes",
                    Address = "Av. Brasil, 442",
                    City = "Campinas",
                    PostalCode = "04876-786",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "GREAL",
                    CompanyName = "Great Lakes Food Market",
                    Address = "2732 Baker Blvd.",
                    City = "Eugene",
                    PostalCode = "97403",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "GROSR",
                    CompanyName = "GROSELLA-Restaurante",
                    Address = "5ª Ave. Los Palos Grandes",
                    City = "Caracas",
                    PostalCode = "1081",
                    Country = "Venezuela"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "HANAR",
                    CompanyName = "Hanari Carnes",
                    Address = "Rua do Paço, 67",
                    City = "Rio de Janeiro",
                    PostalCode = "05454-876",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "HILAA",
                    CompanyName = "HILARIÓN-Abastos",
                    Address = "Carrera 22 con Ave. Carlos Soublette #8-35",
                    City = "San Cristóbal",
                    PostalCode = "5022",
                    Country = "Venezuela"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "HUNGC",
                    CompanyName = "Hungry Coyote Import Store",
                    Address = "City Center Plaza 516 Main St.",
                    City = "Elgin",
                    PostalCode = "97827",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "HUNGO",
                    CompanyName = "Hungry Owl All-Night Grocers",
                    Address = "8 Johnstown Road",
                    City = "Cork",
                    PostalCode = "",
                    Country = "Ireland"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "ISLAT",
                    CompanyName = "Island Trading",
                    Address = "Garden House Crowther Way",
                    City = "Cowes",
                    PostalCode = "PO31 7PJ",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "KOENE",
                    CompanyName = "Königlich Essen",
                    Address = "Maubelstr. 90",
                    City = "Brandenburg",
                    PostalCode = "14776",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LACOR",
                    CompanyName = "La corne d'abondance",
                    Address = "67, avenue de l'Europe",
                    City = "Versailles",
                    PostalCode = "78000",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LAMAI",
                    CompanyName = "La maison d'Asie",
                    Address = "1 rue Alsace-Lorraine",
                    City = "Toulouse",
                    PostalCode = "31000",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LAUGB",
                    CompanyName = "Laughing Bacchus Wine Cellars",
                    Address = "1900 Oak St.",
                    City = "Vancouver",
                    PostalCode = "V3F 2K1",
                    Country = "Canada"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LAZYK",
                    CompanyName = "Lazy K Kountry Store",
                    Address = "12 Orchestra Terrace",
                    City = "Walla Walla",
                    PostalCode = "99362",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LEHMS",
                    CompanyName = "Lehmanns Marktstand",
                    Address = "Magazinweg 7",
                    City = "Frankfurt a.M. ",
                    PostalCode = "60528",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LETSS",
                    CompanyName = "Let's Stop N Shop",
                    Address = "87 Polk St. Suite 5",
                    City = "San Francisco",
                    PostalCode = "94117",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LILAS",
                    CompanyName = "LILA-Supermercado",
                    Address = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
                    City = "Barquisimeto",
                    PostalCode = "3508",
                    Country = "Venezuela"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LINOD",
                    CompanyName = "LINO-Delicateses",
                    Address = "Ave. 5 de Mayo Porlamar",
                    City = "I. de Margarita",
                    PostalCode = "4980",
                    Country = "Venezuela"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "LONEP",
                    CompanyName = "Lonesome Pine Restaurant",
                    Address = "89 Chiaroscuro Rd.",
                    City = "Portland",
                    PostalCode = "97219",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "MAGAA",
                    CompanyName = "Magazzini Alimentari Riuniti",
                    Address = "Via Ludovico il Moro 22",
                    City = "Bergamo",
                    PostalCode = "24100",
                    Country = "Italy"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "MAISD",
                    CompanyName = "Maison Dewey",
                    Address = "Rue Joseph-Bens 532",
                    City = "Bruxelles",
                    PostalCode = "B-1180",
                    Country = "Belgium"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "MEREP",
                    CompanyName = "Mère Paillarde",
                    Address = "43 rue St. Laurent",
                    City = "Montréal",
                    PostalCode = "H1J 1C3",
                    Country = "Canada"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "MORGK",
                    CompanyName = "Morgenstern Gesundkost",
                    Address = "Heerstr. 22",
                    City = "Leipzig",
                    PostalCode = "04179",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "NORTS",
                    CompanyName = "North/South",
                    Address = "South House 300 Queensbridge",
                    City = "London",
                    PostalCode = "SW7 1RZ",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "OCEAN",
                    CompanyName = "Océano Atlántico Ltda.",
                    Address = "Ing. Gustavo Moncada 8585 Piso 20-A",
                    City = "Buenos Aires",
                    PostalCode = "1010",
                    Country = "Argentina"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "OLDWO",
                    CompanyName = "Old World Delicatessen",
                    Address = "2743 Bering St.",
                    City = "Anchorage",
                    PostalCode = "99508",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "OTTIK",
                    CompanyName = "Ottilies Käseladen",
                    Address = "Mehrheimerstr. 369",
                    City = "Köln",
                    PostalCode = "50739",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "PARIS",
                    CompanyName = "Paris spécialités",
                    Address = "265, boulevard Charonne",
                    City = "Paris",
                    PostalCode = "75012",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "PERIC",
                    CompanyName = "Pericles Comidas clásicas",
                    Address = "Calle Dr. Jorge Cash 321",
                    City = "México D.F.",
                    PostalCode = "05033",
                    Country = "Mexico"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "PICCO",
                    CompanyName = "Piccolo und mehr",
                    Address = "Geislweg 14",
                    City = "Salzburg",
                    PostalCode = "5020",
                    Country = "Austria"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "PRINI",
                    CompanyName = "Princesa Isabel Vinhos",
                    Address = "Estrada da saúde n. 58",
                    City = "Lisboa",
                    PostalCode = "1756",
                    Country = "Portugal"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "QUEDE",
                    CompanyName = "Que Delícia",
                    Address = "Rua da Panificadora, 12",
                    City = "Rio de Janeiro",
                    PostalCode = "02389-673",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "QUEEN",
                    CompanyName = "Queen Cozinha",
                    Address = "Alameda dos Canàrios, 891",
                    City = "São Paulo",
                    PostalCode = "05487-020",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "QUICK",
                    CompanyName = "QUICK-Stop",
                    Address = "Taucherstraße 10",
                    City = "Cunewalde",
                    PostalCode = "01307",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "RANCH",
                    CompanyName = "Rancho grande",
                    Address = "Av. del Libertador 900",
                    City = "Buenos Aires",
                    PostalCode = "1010",
                    Country = "Argentina"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "RATTC",
                    CompanyName = "Rattlesnake Canyon Grocery",
                    Address = "2817 Milton Dr.",
                    City = "Albuquerque",
                    PostalCode = "87110",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "REGGC",
                    CompanyName = "Reggiani Caseifici",
                    Address = "Strada Provinciale 124",
                    City = "Reggio Emilia",
                    PostalCode = "42100",
                    Country = "Italy"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "RICAR",
                    CompanyName = "Ricardo Adocicados",
                    Address = "Av. Copacabana, 267",
                    City = "Rio de Janeiro",
                    PostalCode = "02389-890",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "RICSU",
                    CompanyName = "Richter Supermarkt",
                    Address = "Grenzacherweg 237",
                    City = "Genève",
                    PostalCode = "1203",
                    Country = "Switzerland"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "ROMEY",
                    CompanyName = "Romero y tomillo",
                    Address = "Gran Vía, 1",
                    City = "Madrid",
                    PostalCode = "28001",
                    Country = "Spain"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SANTG",
                    CompanyName = "Santé Gourmet",
                    Address = "Erling Skakkes gate 78",
                    City = "Stavern",
                    PostalCode = "4110",
                    Country = "Norway"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SAVEA",
                    CompanyName = "Save-a-lot Markets",
                    Address = "187 Suffolk Ln.",
                    City = "Boise",
                    PostalCode = "83720",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SEVES",
                    CompanyName = "Seven Seas Imports",
                    Address = "90 Wadhurst Rd.",
                    City = "London",
                    PostalCode = "OX15 4NB",
                    Country = "UK"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SIMOB",
                    CompanyName = "Simons bistro",
                    Address = "Vinbæltet 34",
                    City = "København",
                    PostalCode = "1734",
                    Country = "Denmark"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SPECD",
                    CompanyName = "Spécialités du monde",
                    Address = "25, rue Lauriston",
                    City = "Paris",
                    PostalCode = "75016",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SPLIR",
                    CompanyName = "Split Rail Beer & Ale",
                    Address = "P.O. Box 555",
                    City = "Lander",
                    PostalCode = "82520",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "SUPRD",
                    CompanyName = "Suprêmes délices",
                    Address = "Boulevard Tirou, 255",
                    City = "Charleroi",
                    PostalCode = "B-6000",
                    Country = "Belgium"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "THEBI",
                    CompanyName = "The Big Cheese",
                    Address = "89 Jefferson Way Suite 2",
                    City = "Portland",
                    PostalCode = "97201",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "THECR",
                    CompanyName = "The Cracker Box",
                    Address = "55 Grizzly Peak Rd.",
                    City = "Butte",
                    PostalCode = "59801",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "TOMSP",
                    CompanyName = "Toms Spezialitäten",
                    Address = "Luisenstr. 48",
                    City = "Münster",
                    PostalCode = "44087",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "TORTU",
                    CompanyName = "Tortuga Restaurante",
                    Address = "Avda. Azteca 123",
                    City = "México D.F.",
                    PostalCode = "05033",
                    Country = "Mexico"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "TRADH",
                    CompanyName = "Tradição Hipermercados",
                    Address = "Av. Inês de Castro, 414",
                    City = "São Paulo",
                    PostalCode = "05634-030",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "TRAIH",
                    CompanyName = "Trail's Head Gourmet Provisioners",
                    Address = "722 DaVinci Blvd.",
                    City = "Kirkland",
                    PostalCode = "98034",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "VAFFE",
                    CompanyName = "Vaffeljernet",
                    Address = "Smagsløget 45",
                    City = "Århus",
                    PostalCode = "8200",
                    Country = "Denmark"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "VICTE",
                    CompanyName = "Victuailles en stock",
                    Address = "2, rue du Commerce",
                    City = "Lyon",
                    PostalCode = "69004",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "VINET",
                    CompanyName = "Vins et alcools Chevalier",
                    Address = "59 rue de l'Abbaye",
                    City = "Reims",
                    PostalCode = "51100",
                    Country = "France"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "WANDK",
                    CompanyName = "Die Wandernde Kuh",
                    Address = "Adenauerallee 900",
                    City = "Stuttgart",
                    PostalCode = "70563",
                    Country = "Germany"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "WARTH",
                    CompanyName = "Wartian Herkku",
                    Address = "Torikatu 38",
                    City = "Oulu",
                    PostalCode = "90110",
                    Country = "Finland"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "WELLI",
                    CompanyName = "Wellington Importadora",
                    Address = "Rua do Mercado, 12",
                    City = "Resende",
                    PostalCode = "08737-363",
                    Country = "Brazil"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "WHITC",
                    CompanyName = "White Clover Markets",
                    Address = "305 - 14th Ave. S. Suite 3B",
                    City = "Seattle",
                    PostalCode = "98128",
                    Country = "USA"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "WILMK",
                    CompanyName = "Wilman Kala",
                    Address = "Keskuskatu 45",
                    City = "Helsinki",
                    PostalCode = "21240",
                    Country = "Finland"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                CustomerDetail = new CustomerDetails()
                {
                    CustomerID = "WOLZA",
                    CompanyName = "Wolski  Zajazd",
                    Address = "ul. Filtrowa 68",
                    City = "Warszawa",
                    PostalCode = "01-012",
                    Country = "Poland"
                };
                CustomerDetailsCollection.Add(CustomerDetail);
                return CustomerDetailsCollection;
            }
        }
    }
}