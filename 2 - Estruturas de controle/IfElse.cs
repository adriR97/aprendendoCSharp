using System;

namespace IfElse {
	class Program {
		static void Main(string[] args){
		    
		    /*
                if(condição) {
                    se for verdadeiro executa o bloco do if
                } else {
                    se for falso executa o bloco do else
                }
            */
            
            int numero1 = 23;
            int numero2 = 32;
            
            if(numero1 > numero2) {
                Console.WriteLine("O primeiro número é maior");
            } else if(numero1 == numero2) {
                Console.WriteLine("Os números são iguais");
            } else {
                Console.WriteLine("O segundo número é maior");
            }
            
    	}
	}	
}