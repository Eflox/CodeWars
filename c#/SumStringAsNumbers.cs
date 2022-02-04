/*
 * Given the string representations of two integers, return the string
 * representation of the sum of those integers.
 * 
 * For example:
 * 
 * sumStrings('1','2') // => '3'
 * A string representation of an integer will contain no characters
 * besides the ten numerals "0" to "9".
*/

using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        BigInteger n1 = 0;
        BigInteger n2 = 0;

        foreach (char c in a)
        {
            n1 += (ulong)c - 48;
            n1 *= 10;
        }
        n1 /= 10;
        foreach (char c in b)
        {
            n2 += (ulong)c - 48;
            n2 *= 10;
        }
        n2 /= 10;
        return (n1 + n2).ToString();
    }
}