using System;

namespace BreakContinue 
{
	class Program 
	{
		static void Main(string[] args)
		{
		    
			/*
                		break -> usado para sair de um loop ou do switch;
                		continue -> usado somente em loops, ele salta para a próxima verificação de condição;
            		*/
            
            		Console.WriteLine("BREAK\n");
            
            		for(int i=0; i<=10; i++) 
			{
                		if(i == 8) 
				{
                    			//para o laço assim que achar o número 8
                    			break;
                		} 
				else 
				{
                    			Console.WriteLine(i);
                		}
            		}
            
            		Console.WriteLine("\nCONTINUE\n");
            
            		for(int i=0; i<=10; i++) 
			{
                		if(i == 8) 
				{
                    			//pula o número 8 e vai para a próxima verificação
                    			continue;
                		} 
				else 
				{
                    			Console.WriteLine(i);
                		}
            		}
            
    		}
	}	
}