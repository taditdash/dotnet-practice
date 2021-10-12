using System;
using System.Collections.Generic;

namespace problem_solving
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Filter Products From Repo

            //FilterProductsFromRepo.cs
            // var repo = new List<string> {
            //     "5", "bags", "batteries", "baby monitor", "barbie", "bags", "bagsmart", "baggage"
            // };

            // var results = FilterProductsFromRepo.SuggestProducts(repo, "bags");

            // foreach (var data in results)
            // {
            //     foreach (var item in data)
            //     {
            //         Console.Write(item + ", ");
            //     }

            //     Console.WriteLine();
            // }

            #endregion

            #region Recursion

            // Recusrsion.cs

            Console.WriteLine(Recursion.Sum(new int[] {4, 7, 8, 9}));

            #endregion
        }
    }
}
