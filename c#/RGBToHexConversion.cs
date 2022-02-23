/*
 * The rgb function is incomplete. Complete it so that passing in RGB decimal
 * values will result in a hexadecimal representation being returned.
 * Valid decimal values for RGB are 0 - 255. Any values that fall out of
 * that range must be rounded to the closest valid value.
 * 
 * Note: Your answer should always be 6 characters long,
 * the shorthand with 3 will not work here.
 * 
 * The following are examples of expected output values:
 * 
 * Rgb(255, 255, 255) # returns FFFFFF
 * Rgb(255, 255, 300) # returns FFFFFF
 * Rgb(0,0,0) # returns 000000
 * Rgb(148, 0, 211) # returns 9400D3
*/

public class Kata
{ 
  public static string Rgb(int r, int g, int b) 
  {
    r = (r > 255) ? 255 : r;
    g = (g > 255) ? 255 : g;
    b = (b > 255) ? 255 : b;
    r = (r < 0) ? 0 : r;
    g = (g < 0) ? 0 : g;
    b = (b < 0) ? 0 : b;
    return r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
  }
}
