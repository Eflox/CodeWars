/*
 * Write a function, which takes a non-negative integer (seconds) as input
 * and returns the time in a human-readable format (HH:MM:SS)
 * 
 * HH = hours, padded to 2 digits, range: 00 - 99
 * MM = minutes, padded to 2 digits, range: 00 - 59
 * SS = seconds, padded to 2 digits, range: 00 - 59
 * The maximum time never exceeds 359999 (99:59:59)
 * 
 * You can find some examples in the test fixtures.
*/

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int secs = 0;
        int mins = 0;
        int hours = 0;

        for (int i = 0; i < seconds; i++)
        {
            secs++;
            if (secs == 60)
            {
                secs = 0;
                mins++;
            }
            if (mins == 60)
            {
                mins = 0;
                hours++;
            }
        }

        string h = hours.ToString();
        string m = mins.ToString();
        string s = secs.ToString();

        if (hours == 0)
            h = "00";
        else if (hours < 10)
            h = "0" + h;
        if (mins == 0)
            m = "00";
        else if (mins < 10)
            m = "0" + m;
        if (secs == 0)
            s = "00";
        else if (secs < 10)
            s = "0" + s;

        return h + ":" + m + ":" + s;
    }
}