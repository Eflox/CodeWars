/*
 * Jaden Smith, the son of Will Smith, is the star of films such as 
 * he Karate Kid (2010) and After Earth (2013). Jaden is also known for some
 * of his philosophy that he delivers via Twitter. When writing on Twitter,
 * he is known for almost always capitalizing every word. For simplicity,
 * you'll have to capitalize each word, check out how contractions are expected
 * to be in the example below.
 * 
 * Your task is to convert strings to how they would be written by Jaden Smith.
 * The strings are actual quotes from Jaden Smith, but they are not capitalized
 * in the same way he originally typed them.
*/

using System;
using System.Linq;

public static class JadenCase
{
	public static string ToJadenCase(this string phrase)
	{
		return string.Join(" ", phrase.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));
	}
}