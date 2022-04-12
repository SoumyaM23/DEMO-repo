using System;
using System.Linq;
public class Program 
{
    public static double[] FindMinMax(double[] values) 
    {
				double[] ar = new double[2];
			  ar[0] = values.Min();
			  ar[1] = values.Max();
			
			return ar;
    }
}