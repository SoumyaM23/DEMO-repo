using System;
using System.Collections.Generic;
public class Test {
  public static void Main() {
   
	  Dictionary<int,String> d = new Dictionary<int, String>();
	  d.Add(11,"Yashi");
	  d.Add(2,"Watler");
	  d.Add(130,"Ram");
	  d.Add(51,"Jamal");
	  
	  ICollection<int> keys = d.Keys;
	  Console.WriteLine("Keys:");
	  foreach(var k in keys)
		  Console.WriteLine(k);
	  
	   ICollection<String> values = d.Values;
	  Console.WriteLine("Values:");
	  foreach(var v in values)
		  Console.WriteLine(v);
	  
	  Console.WriteLine("Value with key: {0} ", d[2]);
	  d.Remove(2);
	 // Console.WriteLine("Value with key: {0} ", d[2]);
	  Console.WriteLine("check if key present: {0} ", d.ContainsKey(2));
	  d.Add(2,"Hariom");
	   Console.WriteLine("Value with key: {0} ", d[2]);
	  
	   Console.WriteLine("Count: {0} ", d.Count);
	  
  }
}
	  