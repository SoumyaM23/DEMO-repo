using System;
using System.Collections;

public class Test{
	public static void Main(string[]args)
	{
 
		Hashtable h = new Hashtable();
		h.Add("001","Vidya");
		h.Add("002","Neena");
		h.Add("003","Ramesh");
		Console.WriteLine("Count of elements= {0}",h.Count);
		Console.WriteLine("accessing value uing key: {0}",h["001"]);
		
		ICollection key = h.Keys;
		Console.Write("KEYS:");
		foreach(var k in key)
			Console.Write(" {0}",k);
		Console.WriteLine();
		
		ICollection values = h.Values;
		Console.Write("VALUES:");
		foreach(var v in values)
			Console.Write(" {0}",v);
		Console.WriteLine();
		
		h.Remove("002");
		Console.Write("After removing one element:");
		foreach(var k in key)
			Console.Write(" {0}",k);
		Console.WriteLine();
		
		Console.WriteLine("Contains key '002'?:{0}",h.ContainsKey("002"));
		Console.WriteLine("Contains value 'Ramesh'?:{0}",h.ContainsValue("Ramesh"));
		
		h.Clear();
		Console.WriteLine("Count after clearing:",h.Count);
	}
}