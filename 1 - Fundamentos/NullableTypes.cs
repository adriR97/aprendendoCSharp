using System;

namespace NullableTypes 
{
	class Program 
	{
		static void Main(string[] args)
		{
			
			/* Atribuindo valores nulos aos tipos primitivos, 
			   útil para realizar operações em banco de dados */
			   
			int? numero = null;
			
			if(numero != null)
				Console.WriteLine("Não é nulo");
			else
				Console.WriteLine("É nulo");			
			
		}
	}	
}