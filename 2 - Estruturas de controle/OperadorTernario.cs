using System;

namespace OperadorTernario 
{
	class Program 
	{
		static void Main(string[] args)
		{
		    
			/* 
    				(condicao) ? "se for verdadeiro executa este bloco" : "se for falsa executa este" 
    			*/
    
            		int numero = 5;
            		string resposta;
            
            		resposta = (numero > 10) ? "5 é maior que 10" : "5 é menor que 10";
            
            		Console.WriteLine(resposta);
            
    		}
	}	
}