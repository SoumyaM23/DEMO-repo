using System;
using System.Collections;

public class Test{
	public static void Main(string[]args)
	{
      Queue q = new Queue();
	  q.Enqueue(6);	
	  q.Enqueue(71);	
	  q.Enqueue(19);
	  q.Enqueue(55);	
		
	Console.WriteLine("Number of elements in Queue:{0}",q.Count);	
			
	Console.Write("Queue elements:");	
	foreach(var i in q)
		Console.Write(" {0}",i);
	Console.WriteLine();	
		
	Console.WriteLine("Dequeue of first element:{0}",q.Dequeue());
	Console.WriteLine("Number of elements in Queue:{0}",q.Count);	
	Console.WriteLine("Contains '55?':{0}",q.Contains(55));	
	
	
	object[] ar = q.ToArray();
	Console.Write("array elements:{0}");
	foreach(var i in ar)
		Console.Write(" {0}",i);
	Console.WriteLine();	
		
	q.Clear();
	Console.WriteLine("Number of elements in Queue:{0}",q.Count);
		
			
		
	}
}