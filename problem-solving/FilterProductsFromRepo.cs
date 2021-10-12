using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
  public class FilterProductsFromRepo
  {
      public static List<List<string>> SuggestProducts(List<string> repositories, string query) {
      List<List<string>> results = new List<List<string>>();

      repositories.Distinct().ToList().Sort();
      
      var queryCopy = "";
      int count = 2;
      while (queryCopy != query) {
          queryCopy = query.Substring(0, count);
          
          var findMatches = repositories
              .Where(x => x.StartsWith(queryCopy))
              .Take(3).ToList();

          results.Add(findMatches);
          
          count++;
      }

      return results;
    }
  }
}