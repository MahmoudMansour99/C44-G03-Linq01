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


        }
    }
}
