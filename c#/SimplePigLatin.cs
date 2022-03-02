/*
 * Move the first letter of each word to the end of it,
 * then add "ay" to the end of the word. Leave punctuation marks untouched.
 * 
 * Examples
 * Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
 * Kata.PigIt("Hello world !");     // elloHay orldway !
*/

using System;

public class Kata
{
  public static string Reverse( string s )
  {
    char[] charArray = s.ToCharArray();
    char tmp = charArray[0];
    
    for(int i = 1; i < charArray.Length; i++)
      charArray[i - 1] = charArray[i];
    charArray[charArray.Length - 1] = tmp;
    return new string(charArray);
  }
  
  public static string PigIt(string str)
  {
    string final = null;
    string[] tmp = str.Split(' ');
    var last = tmp[tmp.Length - 1];
    
    foreach (string word in str.Split(' '))
    {
      final += Reverse(word);
      final += (word != "!") ? "ay" : "";
      final += (word != last) ? " " : "";
    }
    return final;
  }
}
