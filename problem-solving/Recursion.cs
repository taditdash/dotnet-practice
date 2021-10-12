using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_solving
{
  public class Recursion
  {
    public static int Sum(int[] input) {
      if (input.Count() == 1) return input[0];
      
      int[] smallInput = new int[input.Count() - 1];
      for (int i = 1; i < input.Count(); i++) {
          smallInput[i - 1] = input[i];
      }
      
      return input[0] + Sum(smallInput);
	    }
  }
}

