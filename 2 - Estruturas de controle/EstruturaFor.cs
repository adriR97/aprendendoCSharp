using System;

namespace EstruturaFor {
	class Program {
		static void Main(string[] args){
		    
		    /*
                for(inicialização; condição; incremento) {
                    codigo;
                }
            */
            
            Console.WriteLine("Números pares: ");
            
            for(int i=0; i<=20; i++) {
                if(i%2 == 0) {
                    Console.WriteLine(i);
                }
            }
            
    	}
	}	
}