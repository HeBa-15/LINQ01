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

        }
    }
}