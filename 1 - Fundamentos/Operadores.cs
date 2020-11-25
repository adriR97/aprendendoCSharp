using System;

namespace Operadores {
	class Program {
		static void Main(string[] args){
		    
		    int n1 = 10, n2 = 30;
		    
			/* Operadores Aritméticos */
			Console.WriteLine("Operadores Aritméticos");
			Console.WriteLine(10 + 20); //soma
			Console.WriteLine(30 - 20); //subtração
			Console.WriteLine(10 * 20); //multiplicação
			Console.WriteLine(20 / 5);  //divisão
			Console.WriteLine(5 % 2);   //módulo -> resto da divisão
			n1++;  //incremento
			Console.WriteLine(n1);
			n2--;  //decremento
			Console.WriteLine(n2);
			
			/* Operadores de Atribuição */
			Console.WriteLine("\nOperadores de Atribuição");
			n1 = 20;
			Console.WriteLine(n1);
			Console.WriteLine(n1 += 5); // 20 + 5 = 25
			Console.WriteLine(n1 -= 5); // 25 - 5 = 20
			Console.WriteLine(n1 *= 5); // 20 * 5 = 100
			Console.WriteLine(n1 /= 5); // 100 / 5 = 20
			Console.WriteLine(n1 %= 3); //20 % 3 = 2
			
			/* Operadores de Comparação */
			Console.WriteLine("\nOperadores de Comparação");
			Console.WriteLine(5 == 5);  //igual
			Console.WriteLine(5 != 5);  //diferente
			Console.WriteLine(5 > 4);   //maior que
			Console.WriteLine(5 < 2);   //menor que
			Console.WriteLine(5 >= 5);  //maior ou igual
			Console.WriteLine(5 <= 5);  //menor ou igual 
			
			/* Operadores de Lógica 
			   a && b   -> os dois tem que ser verdadeiros
			   a || b   -> somente um verdadeiro
			   !(a < b) -> inverso do resultado
 			*/
		}
	}	
}