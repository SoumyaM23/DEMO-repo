using System;
public class Program 
{
    public static long CalculateExponent(long number, long exponent) 
    {
			long val = Convert.ToInt64(Math.Pow(number, exponent));
			return val;
    }
	
}