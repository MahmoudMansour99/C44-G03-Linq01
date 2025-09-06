namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implictly Type Local Variable [var - dynamic]

            #region Var Keyword
            //string Data = "Ahmed";
            //var Data = "Ahmed"; // Implictly Type 
            //                    // Compiler will detect Datatype of variable at compilation time
            //                    // Based on its inital value 

            ////var x = null; // invalid 

            //Data = null;
            //var Data; // Inavlid 
            //Data = "Mustafa";

            //Data = 10; // Invalid 
            #endregion

            #region dynamic keyword
            //dynamic Data = "Ali";
            // CLR Will detect Datatype of variable at runtime
            // based on its last assigned value

            //dynamic X;

            //dynamic Y = 10;

            //Data = 10;

            //Console.WriteLine(Data);
            //Data = true;
            //Console.WriteLine(Data);

            #endregion

            #endregion

            #region Extension Method
            //int X = 12345;
            //int Y = X.Reverse();
            //Console.WriteLine(Y);

            //long A = 123456789156;
            //long B = A.Reverse();
            //Console.WriteLine(B);
            #endregion

            #region Anonymous Type
            //Employee employee = new Employee() { Id = 10, Name = "Mona", Salary = 8000 };

            //object Emp01 = new { Id = 10, Name = "Mona", Salary = 8000 };

            //Console.WriteLine(Emp01);

            //var Emp03 = new { Id = 10, Name = "Mona", Salary = 8000 };

            //Console.WriteLine(Emp03.GetType().Name); // <>f__AnonymousType0`3

            //var Emp04 = new { Id = Emp03.Id, Name = Emp03.Name, Salary = 5000 };

            //Console.WriteLine(Emp04.GetType().Name);

            //var Emp05 = Emp03 with { Salary = 4000 };

            //Console.WriteLine(Emp05.GetType().Name);

            //var Emp06 = new { id = 10, Name = "Mona", Salary = 8000 };
            #endregion

            #region What is LINQ
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> oddNumbers = Numbers.Where(num => num % 2 == 0).ToList();

            //foreach (var num in oddNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
        }
    }
}
