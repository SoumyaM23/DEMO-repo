using System;

public class GenericClass<T>{
public bool compare(T x, T y){

	if(x.Equals(y))
		return true;
	else
		return false;
}
}

public class Test{
public static void Main(String[] args){
	
	GenericClass<String> G1 = new GenericClass<String>();
	bool res1 = G1.compare("Good","good");
	Console.WriteLine("Result of comparing two strings:{0}",res1);
	
	GenericClass<Double> G2 = new GenericClass<Double>();
	bool res2 = G2.compare(21.5,21.5);
	Console.WriteLine("Result of comparing two double values:{0}",res2);
	
}
}