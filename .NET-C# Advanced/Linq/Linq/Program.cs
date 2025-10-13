
using Linq;

var employees = new List<Employee>
            {
                new Employee{ Id=1, Name="Ravi", Department="IT", Salary=85000, Experience=5, Location="Bangalore"},
                new Employee{ Id=2, Name="Priya", Department="HR", Salary=52000, Experience=4, Location="Pune"},
                new Employee{ Id=3, Name="Kiran", Department="Finance", Salary=73000, Experience=6, Location="Hyderabad"},
                new Employee{ Id=4, Name="Asha", Department="IT", Salary=95000, Experience=8, Location="Bangalore"},
                new Employee{ Id=5, Name="Vijay", Department="Marketing", Salary=68000, Experience=5, Location="Mumbai"},
                new Employee{ Id=6, Name="Deepa", Department="HR", Salary=61000, Experience=7, Location="Delhi"},
                new Employee{ Id=7, Name="Arjun", Department="Finance", Salary=82000, Experience=9, Location="Bangalore"},
                new Employee{ Id=8, Name="Sneha", Department="IT", Salary=78000, Experience=4, Location="Pune"},
                new Employee{ Id=9, Name="Rohit", Department="Marketing", Salary=90000, Experience=10, Location="Delhi"},
                new Employee{ Id=10, Name="Meena", Department="Finance", Salary=66000, Experience=3, Location="Mumbai"}
            };

//Product Data

var products = new List<Product>
            {
                new Product{ Id=1, Name="Laptop", Category="Electronics", Price=75000, Stock=15 },
                new Product{ Id=2, Name="Smartphone", Category="Electronics", Price=55000, Stock=25 },
                new Product{ Id=3, Name="Tablet", Category="Electronics", Price=30000, Stock=10 },
                new Product{ Id=4, Name="Headphones", Category="Accessories", Price=2000, Stock=100 },
                new Product{ Id=5, Name="Shirt", Category="Fashion", Price=1500, Stock=50 },
                new Product{ Id=6, Name="Jeans", Category="Fashion", Price=2200, Stock=30 },
                new Product{ Id=7, Name="Shoes", Category="Fashion", Price=3500, Stock=20 },
                new Product{ Id=8, Name="Refrigerator", Category="Appliances", Price=45000, Stock=8 },
                new Product{ Id=9, Name="Washing Machine", Category="Appliances", Price=38000, Stock=6 },
                new Product{ Id=10, Name="Microwave", Category="Appliances", Price=12000, Stock=12 }
            };

//Student Data

var students = new List<Student>
            {
                new Student{ Id=1, Name="Asha", Course="C#", Marks=92, City="Bangalore"},
                new Student{ Id=2, Name="Ravi", Course="Java", Marks=85, City="Pune"},
                new Student{ Id=3, Name="Sneha", Course="Python", Marks=78, City="Hyderabad"},
                new Student{ Id=4, Name="Kiran", Course="C#", Marks=88, City="Delhi"},
                new Student{ Id=5, Name="Meena", Course="Python", Marks=95, City="Bangalore"},
                new Student{ Id=6, Name="Vijay", Course="C#", Marks=82, City="Chennai"},
                new Student{ Id=7, Name="Deepa", Course="Java", Marks=91, City="Mumbai"},
                new Student{ Id=8, Name="Arjun", Course="Python", Marks=89, City="Hyderabad"},
                new Student{ Id=9, Name="Priya", Course="C#", Marks=97, City="Pune"},
                new Student{ Id=10, Name="Rohit", Course="Java", Marks=74, City="Delhi"}
            };

//Order Data

var orders = new List<Order>
            {
                new Order{ OrderId=1001, CustomerId=1, Amount=2500, OrderDate=new DateTime(2025,5,12)},
                new Order{ OrderId=1002, CustomerId=2, Amount=1800, OrderDate=new DateTime(2025,5,13)},
                new Order{ OrderId=1003, CustomerId=1, Amount=4500, OrderDate=new DateTime(2025,5,20)},
                new Order{ OrderId=1004, CustomerId=3, Amount=6700, OrderDate=new DateTime(2025,6,01)},
                new Order{ OrderId=1005, CustomerId=4, Amount=2500, OrderDate=new DateTime(2025,6,02)},
                new Order{ OrderId=1006, CustomerId=2, Amount=5600, OrderDate=new DateTime(2025,6,10)},
                new Order{ OrderId=1007, CustomerId=5, Amount=3100, OrderDate=new DateTime(2025,6,12)},
                new Order{ OrderId=1008, CustomerId=3, Amount=7100, OrderDate=new DateTime(2025,7,01)},
                new Order{ OrderId=1009, CustomerId=4, Amount=4200, OrderDate=new DateTime(2025,7,05)},
                new Order{ OrderId=1010, CustomerId=5, Amount=2900, OrderDate=new DateTime(2025,7,10)}
            };


//Tasks:
//Employee Tasks


//1.Display all employees working in the IT department.
var itemployees = employees.Where(n => n.Department == "IT");
foreach(var employee in itemployees)Console.WriteLine(employee);

//2.List names and salaries of employees who earn more than 70,000.
var salnameEmployees = employees.Where(n => n.Salary > 70000);
foreach( var employee in salnameEmployees) Console.WriteLine($"Name: {employee.Name} | Salary: {employee.Salary}");

//3.Find all employees located in Bangalore.
var bangloreEmployees = employees.Where(n => n.Location== "Bangalore");
foreach (var employee in bangloreEmployees) Console.WriteLine($"Name: {employee.Name}");
//4.Display employees having more than 5 years of experience.
var expEmployees = employees.Where(n => n.Experience > 5);
foreach (var employee in expEmployees) Console.WriteLine($"Name: {employee.Name}");
//5.Show names of employees and their salaries in ascending order of salary.
var ascSalary = employees.OrderBy(n => n.Salary);
foreach (var employee in ascSalary) Console.WriteLine($"Name: {employee.Name}");

//6.Group employees by location and count how many employees are in each location.
var locationGroups = employees.GroupBy(n => n.Location).Select(g => new{Location=g.Key, EmployeeCount=g.Count() });
foreach (var group in locationGroups) Console.WriteLine($"{group.Location}: {group.EmployeeCount} employees");
//7.Display employees whose salary is above the average salary.
var aboveSverageEmployees = employees.Where(n => n.Salary > (employees.Average(n => n.Salary)));\
foreach (var employee in aboveSverageEmployees) Console.WriteLine($"{employee.Name} | {employee.Salary} ");
//8.Show top 3 highest-paid employees.
var top3employees = employees.OrderByDescending(n => n.Salary).Take(3);
foreach(var employee in top3employees) Console.WriteLine($"{employee.Name} | {employee.Salary} ");



//Product Tasks

//1.Display all products with stock less than 20.
var productsbelow20 = products.Where(n => n.Stock < 20);
foreach( var product in productsbelow20) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Stock: {product.Stock}");
//2. Show all products belonging to the “Fashion” category.
var fashionProducts = products.Where(n => n.Category == "Fashion");
foreach (var product in productsbelow20) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Category: {product.Category}");

//3. Display product names and prices where price is greater than 10,000.
var productPrice10000 = products.Where(n => n.Price > 10000);
foreach (var product in productPrice10000) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Price : {product.Price}");

//4. List all product names sorted by price (descending).
var sortbyprice = products.OrderByDescending(n=>n.Price);
foreach (var product in sortbyprice) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Price : {product.Price}");

//5.Find the most expensive product in each category.
var expOnCategory = products.GroupBy(n => n.Category).Select(p => p.OrderByDescending(d=>d.Price).First());
foreach (var product in expOnCategory) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Price : {product.Price}");

//6.Show total stock per category.
var totalStocks = products.GroupBy(n => n.Category).Select(g => new { Category = g.Key, TotalStocks = g.Sum(p => p.Stock)});
foreach (var product in expOnCategory) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Price : {product.Price}");

//7.Display products whose name starts with ‘S’.
var sproducts = products.Where(p => p.Name.StartsWith("S"));
foreach (var product in expOnCategory) Console.WriteLine($"id: {product.Id} | Name:{product.Name} | Price : {product.Price}");

//8.Show average price of products in each category.
var avgPriceCategory = products.GroupBy(p => p.Category)
    .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.Price) });
foreach(var product in avgPriceCategory) Console.WriteLine($"Category: {product.Category} | Name:{product.Name} | Price : {product.Price}");



//Student Tasks

//1.Find the highest scorer in each course.
var highestScorerCourse = students.GroupBy(n => n.Course).Select(p => p.OrderByDescending(d => d.Marks).First());
foreach (var student in highestScorerCourse) Console.WriteLine($"{student.Name} | {student.Marks} {student.Course}");

//2.Display average marks of all students city-wise.
var cityWiseAvgMarks = students.GroupBy(s => s.City).Select(p => new { City = p.Key, AverageMarks = p.Average(p => p.Marks) });
foreach (var student in cityWiseAvgMarks) Console.WriteLine($"{student.City} | {student.AverageMarks} ");

//3.Display names and marks of students ranked by marks.
var marksRankedStudents = students.OrderByDescending(s => s.Marks);
foreach (var student in marksRankedStudents) Console.WriteLine($"{student.Name} | {student.Marks} {student.Course}");


//Order Tasks
 
//1.Find total order amount per month.
 
//2.Show the customer who spent the most in total.
 
//3.Display orders grouped by customer and show total amount spent.
 
//4.Display the top 2 orders with the highest amount.


