/* 
 * Your task is to make a function that can take any non-negative
 * integer as an argument and return it with its digits in descending order.
 * Essentially, rearrange the digits to create the highest possible number.
*/

using System;
using System.Collections.Generic;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    string s = "";
    List<string> numbers = new List<string>();

    while (num > 9) {
      numbers.Add((num % 10).ToString());
      num /= 10;
    }
    
    numbers.Add((num).ToString());
    
    numbers.Sort();
    numbers.Reverse();
    
    for (int i = 0; i < numbers.Count; i++)
      s = s + numbers[i];
    
    return int.Parse(s);
  }
}
