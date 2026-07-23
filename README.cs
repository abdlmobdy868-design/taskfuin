

using ConsoleAppaa.Data;
using System;

 

            using System;
            using System.Linq;

    class Program
    {
        static void Main()
        {
            using var db = new applica();

            // 1- List all customers' first and last names along with their email addresses.
            var q1 = db.Customers
                .Select(c => new { c.FirstName, c.LastName, c.Email });
            q1.ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} - {x.Email}"));

            // 2- Retrieve all orders processed by a specific staff member (e.g., staff_id = 3).
            int staffId = 3;
            var q2 = db.Orders.Where(o => o.StaffId == staffId);

            // 3- Get all products that belong to a category named "Mountain Bikes".
            var q3 = db.Products
                .Where(p => p.Category.CategoryName == "Mountain Bikes");

            // 4- Count the total number of orders per store.
            var q4 = db.Orders
                .GroupBy(o => o.StoreId)
                .Select(g => new { StoreId = g.Key, TotalOrders = g.Count() });

            // 5- List all orders that have not been shipped yet (shipped_date is null).
            var q5 = db.Orders.Where(o => o.ShippedDate == null);

            // 6- Display each customer's full name and the number of orders they have placed.
            var q6 = db.Customers
                .Select(c => new
                {
                    FullName = c.FirstName + " " + c.LastName,
                    OrdersCount = c.Orders.Count()
                });

            // 7- List all products that have never been ordered (not found in order_items).
            var q7 = db.Products
                .Where(p => !p.OrderItems.Any());

            // 8- Display products that have a quantity of less than 5 in any store stock.
            var q8 = db.Stocks
                .Where(s => s.Quantity < 5)
                .Select(s => new { s.Product.ProductName, s.Store.StoreName, s.Quantity });

            // 9- Retrieve the first product from the products table.
            var q9 = db.Products.FirstOrDefault();

            // 10- Retrieve all products from the products table with a certain model year.
            int year = 2018;
            var q10 = db.Products.Where(p => p.ModelYear == year);

            // 11- Display each product with the number of times it was ordered.
            var q11 = db.Products
                .Select(p => new
                {
                    p.ProductName,
                    TimesOrdered = p.OrderItems.Sum(oi => oi.Quantity)
                });

            // 12- Count the number of products in a specific category.
            int categoryId = 1; // مثال
            var q12 = db.Products.Count(p => p.CategoryId == categoryId);

            // 13- Calculate the average list price of products.
            var q13 = db.Products.Average(p => p.ListPrice);

            // 14- Retrieve a specific product from the products table by ID.
            int productId = 1;
            var q14 = db.Products.FirstOrDefault(p => p.ProductId == productId);

            // 15- List all products that were ordered with a quantity greater than 3 in any order.
            var q15 = db.Products
                .Where(p => p.OrderItems.Any(oi => oi.Quantity > 3));

            // 16- Display each staff member’s name and how many orders they processed.
            var q16 = db.Staffs
                .Select(s => new
                {
                    FullName = s.FirstName + " + s.LastName",


                    OrdersProcessed = s.Orders.Count()
                });

            // 17- List active staff members only (active = true) along with their phone numbers.
            var q17 = db.Staffs
                .Where(s => s.StaffId.Active == true)
                .Select(s => new { s.FirstName, s.LastName, s.Phone });

            // 18- List all products with their brand name and category name.
            var q18 = db.Products
                .Select(p => new
                {
                    p.ProductName,
                    Brand = p.Brand.BrandName,
                    Category = p.Category.CategoryName
                });

            // 19- Retrieve orders that are completed. 
            // completed = shipped_date not null and order_status = 4 غالبا
            var q19 = db.Orders
                .Where(o => o.ShippedDate != null && o.OrderStatus == 4);

            // 20- List each product with the total quantity sold (sum of quantity from order_items).
            var q20 = db.Products
                .Select(p => new
                {
                    p.ProductName,
                    TotalSold = p.OrderItems.Sum(oi => oi.Quantity)
                });
        }
    }     
