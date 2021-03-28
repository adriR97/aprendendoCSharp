using System;

namespace OperacoesMath 
{
	class Program 
	{
        	static void Main(string[] args) 
		{
            
            		/* Maior valor entre dois números */
            		Console.WriteLine(Math.Max(7, 12));
            
            		/* Menor valor entre dois números */
            		Console.WriteLine(Math.Min(7, 12));
            
            		/* Raíz quadrada */
            		Console.WriteLine(Math.Sqrt(64));
            
            		/* Valor Absoluto */
            		Console.WriteLine(Math.Abs(-6.3));
            
            		/* Seno */
    			Console.WriteLine(Math.Asin(2));
    		
    			/* Cosseno */
    			Console.WriteLine(Math.Acos(2));
    		
    			/* Tangente */
    			Console.WriteLine(Math.Atan(2));
    		
    			/* Valor arredondado */
    			Console.WriteLine(Math.Round(1.78));
    		
    			/* Valor arredondado para cima */
    			Console.WriteLine(Math.Ceiling(1.5));
    		
    			/* Valor arredondado para baixo */
    			Console.WriteLine(Math.Floor(1.5));
    		
    			/* Valor 2 elevado a 5 */
    			Console.WriteLine(Math.Pow(2, 5));

        	}
    	}
}