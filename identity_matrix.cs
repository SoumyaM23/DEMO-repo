using System;

public class Program{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter size:");
		int size = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0;i<size;i++)
		{
			for(int j=0;j<size;j++)
			{
				if(i==j)
					Console.Write(1);
				else
					Console.Write(0);
			}
			Console.Write("\n");
		}
	}
}