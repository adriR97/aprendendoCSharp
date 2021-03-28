using System;

namespace EstruturaDoWhile 
{
	class Program 
	{
		static void Main(string[] args)
		{
		    
			/*
                		do 
				{
                    			executa a primeira vez e depois continua a repetição enquanto a condição for verdadeira; 
                		} 
				while(condição);
            		*/
            
            		int i = 0;
            
            		do 
			{
                		Console.WriteLine(i);
                		i++; 
            		} 
			while(i < 5);
            
    		}
	}	
}