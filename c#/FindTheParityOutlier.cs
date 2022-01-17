/*
 * You are given an array (which will have a length of at least 3,
 * but could be very large) containing integers.
 * The array is either entirely comprised of odd integers or entirely
 * comprised of even integers except for a single integer N. Write a method
 * that takes the array as an argument and returns this "outlier" N.
*/

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    bool even;
    
    if (integers[0] % 2 == 0 && (integers[1] % 2 == 0 || integers[2] % 2 == 0))
      even = true;
    else
      even = false;
    
    for (int i = 0; i < integers.Length; i++)
    {
      if (!even && integers[i] % 2 == 0)
        return integers[i];
      if (even && integers[i] % 2 != 0)
        return integers[i];
    }
    return -1;
  }
}
