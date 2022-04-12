using System;
using System.Collections;

public class Test{
	public static void Main(string[]args)
	{
		ArrayList ar = new ArrayList(); // 
		
		Console.WriteLine("Capacity:{0}",ar.Capacity);
		Console.WriteLine("Count:{0}",ar.Count);
		ar.Add(9);
		ar.Add("we");
		Console.WriteLine("Capacity:{0}",ar.Capacity);
		Console.WriteLine("Count:{0}",ar.Count);
		ar.Add('a');
		ar.Add(12.0);
		ar.Add(52);
		Console.WriteLine("Capacity:{0}",ar.Capacity);
		Console.WriteLine("Count:{0}",ar.Count);
		
		Console.Write("Elements in Arraylist:");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
		
		ar.Reverse();
		Console.Write("Elements in Arraylist after Reversing:");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
		
		ar.Insert(2, "India");
		Console.Write("Elements in Arraylist after inserting:");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
		
		Console.WriteLine("a in present Array-> {0}", ar.Contains('a'));
		Console.WriteLine("Index of 'a' in present Array-> {0}", ar.IndexOf('a'));
		
		ar.Remove('a');//ar.RemoveAt(3); 
		Console.Write("Elements in Arraylist after removing 'a':");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
		
		ar.Clear();
		Console.WriteLine("Count:{0}",ar.Count);
		Console.Write("Elements in Arraylist after clearing:");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
		
		ar.Add(15);
		ar.Add(212);
		ar.Add(68);
		ar.Add(9);
		Console.Write("Elements in Arraylist before sorting :");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
		
		ar.Sort();
		Console.Write("Elements in Arraylist after sorting :");
		foreach(dynamic i in ar)
			Console.Write(" {0}", i);
		Console.WriteLine();
	}
}