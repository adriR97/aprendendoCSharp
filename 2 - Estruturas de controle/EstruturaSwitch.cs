using System;

namespace EstruturaSwitch 
{
	class Program 
	{
		static void Main(string[] args)
		{
		    
			/*
                		switch(expressão) 
				{
                    			case x: 
                        			se for verdadeiro executa este bloco e continua a verificação;
                    			case y: 
                        			se for verdadeiro executa este bloco e sai do switch por causa do break;
                        			break;
                    			default: 
                        			se não encontrar nenhuma correspondência executa o bloco default;
                        			break;
                		}
            		*/
            
            		int numero = 8;
            
            		switch(numero) 
			{
                		case 5: 
                    			Console.WriteLine("Número é igual a 5");
                    			break;
                		case 7:
                    			Console.WriteLine("Número é igual a 7");
                    			break;
                		default: 
                    			Console.WriteLine("Nenhuma opção correta");
                    			break;
            		}
            
    		}
	}	
}