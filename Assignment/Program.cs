using Assignment.Dat;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Assignment.Data.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            // 1. Find all products that are out of stock.
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((name, index) => name.Length < index).Select(name => name);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LINQ - Element Operators
            // 1.Get first Product out of Stock

            //var Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result);

            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);

            //Console.WriteLine(Result);

            // 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(n => n > 5).ElementAtOrDefault(1);

            //Console.WriteLine(Result);

            #endregion

            #region LINQ - Aggregate Operators
            // 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(oddNum => oddNum % 2 == 1).Count();

            //Console.WriteLine(Result);

            // 2. Return a list of customers and how many orders each has.
            //var Result = CustomersList.Select(C => new
            //{
            //    CustomerName = C.CustomerName,
            //    OrderCounts = C.Orders.Count()
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // 3. Return a list of categories and how many products each has
            //var Result = ProductsList.GroupBy(C => C.Category).Select(P => new
            //{
            //    Category = P.Key,
            //    ProductsCount = P.Count()
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////var Result = Arr.Aggregate((num01, num02) => num01 + num02);
            //var Result = Arr.Sum();

            //Console.WriteLine(Result);

            // 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var totalChars = Words.Sum(w => w.Length);

            //Console.WriteLine(totalChars);

            // 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result = Words.Min(w => w.Length);

            //Console.WriteLine(Result);

            // 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result = Words.Max(w => w.Length);

            //Console.WriteLine(Result);

            // 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var Result = Words.Average(w => w.Length);

            //Console.WriteLine(Result);

            #endregion

            #region LINQ - Ordering Operators
            // 1. Sort a list of products by name
            //var Result = ProductsList.OrderBy(P => P.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item); 
            //}

            // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(S => S, new LengthComparer());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            // 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region LINQ – Transformation Operators
            // 1. Return a sequence of just the names of a list of products.
            //var result = ProductsList.Select(p => p.ProductName);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //    {
            //        Upper = w.ToUpper(),
            //        Lower = w.ToLower()
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}

            // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductsList.Select(p => new
            //    {
            //        p.ProductName,
            //        p.Category,
            //        Price = p.UnitPrice  
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.Category} , {item.Price:C}");
            //}

            // 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((value, index) => new
            //{
            //    Number = value,
            //    InPlace = (value == index)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Number: {item.Number}, {item.InPlace}");
            //}

            // 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b);

            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}

            // 6. Select all orders where the order total is less than 500.00.
            //var result = CustomersList.SelectMany(c => c.Orders).Where(o => o.Total < 500.00m);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 7. Select all orders where the order was made in 1998 or later.
            //var result = CustomersList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
