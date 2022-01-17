/*
 * Digital root is the recursive sum of all the digits in a number.
 * 
 * Given n, take the sum of the digits of n. If that value has more than one digit,
 * continue reducing in this way until a single-digit number is produced.
 * The input will be a non-negative integer.
*/

using System;

public class Number
{
    public int DigitalRoot(long n)
    {
        long c = n;
        int num = 0;
        bool single = false;

        if (n < 10)
            return Convert.ToInt32(n);
        if (n == 10)
            return 1;

        while (single == false)
        {
            while (c > 10)
            {
                num += Convert.ToInt32(c % 10);
                c /= 10;
            }
            num += Convert.ToInt32(c);

            if (num >= 10)
            {
                c = num;
                num = 0;
            }
            else
                single = true;
        }
        return num;
    }
}