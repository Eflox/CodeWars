/*
 * At a job interview, you are challenged to write an algorithm
 * to check if a given string, s, can be formed from two other strings,
 * part1 and part2.
 * 
 * The restriction is that the characters in part1 and part2 should
 * be in the same order as in s.
 * 
 * The interviewer gives you the following example and tells you to
 * figure out the rest from the given test cases.
 * 
 * For example:
 * 
 * 'codewars' is a merge from 'cdw' and 'oears':
 * 
 *     s:  c o d e w a r s   = codewars
 * part1:  c   d   w         = cdw
 * part2:    o   e   a r s   = oears
*/

using System;

public class StringMerger
{
  public static bool isEmpty(char[] arr)
  {
    foreach(char letter in arr)
      if (letter != '\0')
        return false;
    return true;
  }
  
	public static bool isMerge(string s, string part1, string part2)
	{
    if (s.Length != part1.Length + part2.Length)
      return false;
    char[] arr = s.ToCharArray();
    for(int i = 0; i < arr.Length; i++)
    {
      foreach(char letter in part1.ToCharArray())
        if (arr[i] == letter)
          arr[i] = '\0';
      foreach(char letter in part2.ToCharArray())
        if (arr[i] == letter)
          arr[i] = '\0';
    }
    if (isEmpty(arr))
      return true;
		return false;
	}
}
