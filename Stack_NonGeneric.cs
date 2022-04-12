using System;
using System.Collections;

public class Test{
	public static void Main(string[]args)
	{
      Stack st = new Stack();
	  st.Push(8);
	  st.Push(45);
	  st.Push("huy");	
	  st.Push('u');
	
	  Console.WriteLine("Count of stack elements:{0}",st.Count);
	  Console.Write("Stack elements:");	
	  foreach(var i in st)
		  Console.Write(" {0}",i);
	  Console.WriteLine();	
		
	  Console.WriteLine("top element:{0}",st.Peek());
	  Console.WriteLine("pop element:{0}",st.Pop());
	  Console.WriteLine("top element now:{0}",st.Peek());	
	  Console.WriteLine("contains 'u':{0}",st.Contains('u'));	
			
		
	  st.Clear();		
	  Console.WriteLine("Count of stack elements after clearing:{0}",st.Count);
		
	  st.Push(20);
	  st.Push(30);
	  st.Push(40);
		
	 Console.Write("new elements:"); 
	 foreach(var i in st)
		 Console.Write(" {0}",i);
	Console.WriteLine();	
		
	object[] ar =st.ToArray();
	Console.Write("Array elements:");	
	 foreach(var i in ar)
		 Console.Write(" {0}",i);	
	}
}