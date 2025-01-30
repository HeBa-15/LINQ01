using static LINQ01.ListGenerators;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ

            //LINQ => Language Integrated Query , C# 3.0
            // +40 Extension Method Exists in Enumerable class categorized under 13
            //can be used with any type implements IEnumerable interface => {List ,Array ,Dictionary,....}

            // Sequence => Collection
            // 1. Local Sequence  => in memory object , Files{L2O,L2XML,...} 
            // 2. Remote Sequence => L2EF {Sql, Mongo Db ,mysql,Oracle}



            #endregion

            #region LINQ Syntax

            // List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9 };

            // 1. Fluent Syntax

            // 1.1 Calling static method

            // var result = Enumerable.Where(numbers, n => n % 2 == 0);

            // 1.2 Extension Method 

            // var result = numbers.Where(n => n%2 == 0 && n > 5);


            //*****************************************

            // 2.Query Syntax (Query Expression)

            //staring with "From" => "Range variable" in "Collection" must End with select or Group by 

            //var result = from n in numbers
            //             where n % 2 == 0 && n > 5
            //             select n;

            //*******************************************

            // 3.hyprid Syntax

            // var result = (from n in numbers
            //             where n % 2 == 0 
            //             select n).Where(n => n > 5);



            //foreach (int n in result)
            //{
            //    Console.Write($"{n},");
            //}

            #endregion


            #region LINQ Execution


            // 2 Ways for Linq To Execute


            // 1. Differed Execution => (latest update of data between query def and first use of the query result )

            //  All Linq Operators Except 3 => { Element , Aggregate , Casting} operators are differed

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Where(n => n % 2 == 0); // Query Definition

            //numbers.AddRange (new int[] {10, 11, 12, 13, 14, 15 , 16 , 17 , 18 , 19 , 20 } );
            //numbers.RemoveRange(0, 5);

            //foreach (int n in result)
            //{
            //    Console.Write(n);
            //}


            //******************************************

            // 2. Immediate Execution

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.Where(n => n % 2 == 0).ToList(); // Query Definition

            //numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            //numbers.RemoveRange(0, 5);

            //foreach (int n in result)
            //{
            //    Console.Write(n);
            //}


            #endregion


            #region LINQ Data SetUp

            //foreach (var product in ProductList)
            //{
            //    Console.WriteLine(product);
            //}

            //foreach (var c in CustomerList)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Filtration (Restriction) Operator [Where , indexed Where]

            //foreach (var product in ProductList)
            //{
            //    Console.WriteLine(product);
            //}

            // Get all the products that out of stock => UnitOfStock == 0

            // Fluent

            // var result = ProductList.Where(p => p.UnitsInStock == 0);

            //*************

            // Query 

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;

            //Indexed Where

            //  var result = ProductList.Where((product,index) => product.UnitPrice > 50 && index < 10);


            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion


            #region Transformation {Projection} Operators [Select , Indexed Select]

            //var productName = ProductList.Select(p => p.ProductName);

            //foreach (var item in productName)
            //{
            //    Console.WriteLine(item);
            //}

            // Fluent
            //var updateProducts = ProductList.Where(product => product.UnitPrice > 20).Select(product => new Product 
            //{
            //    ProductID = product.ProductID,
            //    ProductName = product.ProductName,
            //    Category= product.Category,
            //    UnitsInStock = product.UnitsInStock,
            //    UnitPrice= product.UnitPrice * 1.2m

            //});

            // Query

            //var updateProducts = from product in ProductList
            //                     select new Product
            //                     {
            //                         ProductID = product.ProductID,
            //                         ProductName = product.ProductName,
            //                         Category = product.Category,
            //                         UnitsInStock = product.UnitsInStock,
            //                         UnitPrice = product.UnitPrice * 1.2m

            //                     } into newProductTable
            //                     where newProductTable.UnitPrice > 20
            //                     select newProductTable;

            //foreach (var item in updateProducts)
            //{
            //    Console.WriteLine(item);
            //}



            //************************************

            //Indexed Select

            //var result = ProductList.Select((p,i) => new { Index=i,p.ProductName});

            //foreach (var item in  result)
            //{
            //    Console.WriteLine($"{item.Index}");
            //}


            //var result = CustomerList.Select(c => c.Orders);

            //var result = CustomerList.SelectMany(c =>  c.Orders);
            //var result = CustomerList.SelectMany( (c, i) => c.Orders.Select(o => new {Index = i, o}));
            //var result = CustomerList
            //    .SelectMany((c, i) => c.Orders
            //    .Select((o) => new 
            //{
            //    CID = c.CustomerID, c.CustomerName, o.OrderID, o.OrderDate, o.Total 
            //}));
           
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int[]> ints = new List<int[]>() { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };


            //var numbers = ints.SelectMany(i => i);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion




        }
    }
}