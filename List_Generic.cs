using System;
using System.Collections.Generic;
public class Test {
  public static void Main() {
   
	  List <int> l =new List<int>();
	  l.Add(9);
	  l.Add(34);
	  l.Add(40);
	  l.Add(8);
	 Console.WriteLine("Elements in List:"); 
	  foreach(var i in l)
		  Console.WriteLine(i);
	  
	  Console.WriteLine("Elements in List After sorting:"); 
	  l.Sort();
	   foreach(var i in l)
		  Console.WriteLine(i);
	  
	  Console.WriteLine("Elements after Reverse:");
	    l.Reverse();
	   foreach(var i in l)
		  Console.WriteLine(i);
	 
	  Console.WriteLine("After removing two elements:");
	  l.Remove(9);
	  l.RemoveAt(0);
	  foreach(var i in l)
		  Console.WriteLine(i);
	  
	  Console.WriteLine("count = {0} ",l.Count);
	  
	  l.Clear();
	  
	  Console.WriteLine("count = {0} ",l.Count);
	  
	  
	}  
  }