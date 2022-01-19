/*
 * Create a function that returns the sum of the two lowest
 * positive numbers given an array of minimum 4 positive integers.
 * No floats or non-positive integers will be passed.
 * 
 * For example, when an array is passed like [19, 5, 42, 2, 77],
 * the output should be 7.
 * 
 * [10, 343445353, 3453445, 3453545353453] should return 3453455.
*/

using System;

public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int n1 = numbers[0];
        int n2 = 0;
        int index = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (n1 > numbers[i])
            {
                n1 = numbers[i];
                index = i;
            }
            else
                n2 = numbers[i];
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (n2 > numbers[i] && index != i)
            {
                n2 = numbers[i];
                Console.WriteLine(i + " - " + index);
            }
        }

        return n1 + n2;
    }
}