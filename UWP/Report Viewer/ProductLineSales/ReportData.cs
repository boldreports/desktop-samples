using BoldReports.UI.Xaml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ProductLineSales
{
    public class ProductLineSales
    {
        public static IList<ReportParameter> GetParameters()
        {
            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter param = new ReportParameter();
            //param.Labels.Add("Bikes");
            //param.Values.Add("1");
            //param.Name = "ProductCategory";
            //parameters.Add(param);

            param = new ReportParameter();
            param.Labels.Add("Road Bikes");
            param.Values.Add("2");
            param.Name = "ProductSubcategory";
            parameters.Add(param);

            param = new ReportParameter();
            param.Values.Add("2003-1-1");
            param.Name = "StartDate";
            parameters.Add(param);

            param = new ReportParameter();
            param.Values.Add("2003-12-31");
            param.Name = "EndDate";
            parameters.Add(param);

            return parameters;
        }

        public class Employee
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string EmployeeID { get; set; }
            public double SaleAmount { get; set; }
            public DateTime OrderDate { get; set; }
            public string ProductSubcategoryID { get; set; }
            public string ProductCategoryID { get; set; }

            public static IList GetTopEmployees(string catId, string subCatId, DateTime startDate, DateTime endDate)
            {
                List<Employee> employees = new List<Employee>();
                Employee employee = null;
                employee = new Employee()
                {
                    LastName = "Blythe",
                    FirstName = "Michael",
                    EmployeeID = "275",
                    SaleAmount = 41608538.6755,
                    OrderDate = DateTime.Parse("2003-1-1"),
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1"

                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Pak",
                    FirstName = "Jae",
                    EmployeeID = "285",
                    SaleAmount = 35294804.7266,
                    OrderDate = DateTime.Parse("2003-6-1"),
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Carson",
                    FirstName = "Jillian",
                    EmployeeID = "277",
                    SaleAmount = 30990517.95,
                    OrderDate = DateTime.Parse("2003-8-1"),
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Mitchell",
                    FirstName = "Linda",
                    EmployeeID = "276",
                    SaleAmount = 29802308.3236,
                    OrderDate = DateTime.Parse("2003-11-1"),
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Ito",
                    FirstName = "Shu",
                    EmployeeID = "281",
                    SaleAmount = 20770828.1686,
                    OrderDate = DateTime.Parse("2003-12-1"),
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);

                employee = new Employee()
                {
                    LastName = "Mitchell",
                    FirstName = "Linda",
                    EmployeeID = "276",
                    SaleAmount = 9132974.375,
                    OrderDate = DateTime.Parse("2003/08/01"),
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Pak",
                    FirstName = "Jae",
                    EmployeeID = "285",
                    SaleAmount = 7973439.8469,
                    OrderDate = DateTime.Parse("2003/11/01"),
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Blythe",
                    FirstName = "Michael",
                    EmployeeID = "275",
                    SaleAmount = 5156210.2513,
                    OrderDate = DateTime.Parse("2003/09/01"),
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Carson",
                    FirstName = "Jillian",
                    EmployeeID = "277",
                    SaleAmount = 4038367.4366,
                    OrderDate = DateTime.Parse("2003/12/01"),
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "saraiva",
                    FirstName = "Jose",
                    EmployeeID = "295",
                    SaleAmount = 3797988.698,
                    OrderDate = DateTime.Parse("2003/07/01"),
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);

                employee = new Employee()
                {
                    LastName = "Varkey",
                    FirstName = "Ranjit",
                    EmployeeID = "296",
                    SaleAmount = 8640302.3729,
                    OrderDate = DateTime.Parse("2003/08/01"),
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Valdez",
                    FirstName = "Rachel",
                    EmployeeID = "286",
                    SaleAmount = 6534427.6663,
                    OrderDate = DateTime.Parse("2003/11/01"),
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Ito",
                    FirstName = "Shu",
                    EmployeeID = "281",
                    SaleAmount = 4317789.4615,
                    OrderDate = DateTime.Parse("2003/07/01"),
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Mitchell",
                    FirstName = "Linda",
                    EmployeeID = "276",
                    SaleAmount = 3949171.4308,
                    OrderDate = DateTime.Parse("2003/07/01"),
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);
                employee = new Employee()
                {
                    LastName = "Pak",
                    FirstName = "Jae",
                    EmployeeID = "285",
                    SaleAmount = 3745099.762,
                    OrderDate = DateTime.Parse("2003/09/01"),
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1"
                };
                employee.FullName = employee.FirstName + employee.LastName;
                employees.Add(employee);

                return employees.Where(emp => emp.OrderDate >= startDate && emp.OrderDate <= endDate && emp.ProductCategoryID.Trim().Equals(catId) && emp.ProductSubcategoryID.Trim().Equals(subCatId)).ToList();
            }
        }

        public class ProductCategory
        {
            public string ProductCategoryID { get; set; }
            public string Name { get; set; }
            public static IList GetProductCategories()
            {
                List<ProductCategory> productCategories = new List<ProductCategory>();
                ProductCategory productCategory = null;
                productCategory = new ProductCategory()
                {
                    ProductCategoryID = "4",
                    Name = "Accessories"
                };
                productCategories.Add(productCategory);
                productCategory = new ProductCategory()
                {
                    ProductCategoryID = "1",
                    Name = "Bikes"
                };
                productCategories.Add(productCategory);
                productCategory = new ProductCategory()
                {
                    ProductCategoryID = "3",
                    Name = "Clothing"
                };
                productCategories.Add(productCategory);
                productCategory = new ProductCategory()
                {
                    ProductCategoryID = "2",
                    Name = "Components"
                };
                productCategories.Add(productCategory);
                return productCategories;
            }
        }

        public class Customer
        {
            public string StoreName { get; set; }
            public double SaleAmount { get; set; }
            public string ProductSubcategoryID { get; set; }
            public string ProductCategoryID { get; set; }
            public DateTime OrderDate { get; set; }
            public static IList GetTopCustomers(string catId, string subCatId, DateTime startDate, DateTime endDate)
            {
                List<Customer> customers = new List<Customer>();
                Customer customer = null;
                customer = new Customer()
                {
                    StoreName = "Excellent Riding Supplies",
                    SaleAmount = 8564441.5333,
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003-1-1")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Totes & Baskets Company",
                    SaleAmount = 8460123.2145,
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003-6-1")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Corner Bicycle Supply",
                    SaleAmount = 8252044.9923,
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003-8-1")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Sheet Metal Manufacturing",
                    SaleAmount = 8020572.7343,
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003-11-1")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Reasonable Bicycle Sales",
                    SaleAmount = 7781217.897,
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003-12-1")
                };
                customers.Add(customer);

                customer = new Customer()
                {
                    StoreName = "Field Trip Store",
                    SaleAmount = 3000397.7319,
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/08/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Brakes and Gears",
                    SaleAmount = 2704505.996,
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/11/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Metropolitan Bicycle Supply",
                    SaleAmount = 2702021.422,
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/11/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Rural Cycle Emporium",
                    SaleAmount = 2606812.634,
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/08/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Registered Cycle Store",
                    SaleAmount = 2017204.104,
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/08/01")
                };
                customers.Add(customer);

                customer = new Customer()
                {
                    StoreName = "Westside Plaza",
                    SaleAmount = 4262773.1789,
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/07/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Perfect Toys",
                    SaleAmount = 3382412.03,
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/08/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Camping and Sports Store",
                    SaleAmount = 3297559.7696,
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/10/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Roadway Bicycle Supply",
                    SaleAmount = 3234122.8172,
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/11/01")
                };
                customers.Add(customer);
                customer = new Customer()
                {
                    StoreName = "Global Bike Retailers",
                    SaleAmount = 2853318.3206,
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1",
                    OrderDate = DateTime.Parse("2003/08/01")
                };
                customers.Add(customer);

                return customers.Where(cust => cust.OrderDate >= startDate && cust.OrderDate <= endDate && cust.ProductCategoryID.Trim().Equals(catId) && cust.ProductSubcategoryID.Trim().Equals(subCatId)).ToList();
            }
        }

        public class SubCategory
        {
            public string ProductSubcategoryID { get; set; }
            public string ProductCategoryID { get; set; }
            public string Name { get; set; }
            public static IList GetProductSubCategories()
            {
                List<SubCategory> subCategories = new List<SubCategory>();
                SubCategory category = null;
                category = new SubCategory()
                {
                    ProductSubcategoryID = "1",
                    ProductCategoryID = "1",
                    Name = "Mountain Bikes"
                };
                subCategories.Add(category);
                category = new SubCategory()
                {
                    ProductSubcategoryID = "2",
                    ProductCategoryID = "1",
                    Name = "Road Bikes"
                };
                subCategories.Add(category);
                category = new SubCategory()
                {
                    ProductSubcategoryID = "3",
                    ProductCategoryID = "1",
                    Name = "Touring Bikes"
                };
                subCategories.Add(category);
                return subCategories;
            }
        }
    }
}
