using System;

namespace Operadores {
	class Program {
		static void Main(string[] args){
			
			/* Operadores de Atribuição */
		
			int numeroAtribuido = 20;
			Console.WriteLine("----- Operadores de Atribuição -----");
			Console.WriteLine("Valor atribuído à variável: " + numeroAtribuido);
			Console.WriteLine("+= : 20 + 5 = " + (numeroAtribuido += 5));
			Console.WriteLine("-= : 25 - 5 = " + (numeroAtribuido -= 5));
			Console.WriteLine("*= : 20 * 5 = " + (numeroAtribuido *= 5));
			Console.WriteLine("/= : 100 / 5 = " + (numeroAtribuido /= 5));
			Console.WriteLine("%= : 20 % 3 = " + (numeroAtribuido %= 3));
			
			/* Operadores Aritméticos */
		
			Console.WriteLine("\n------ Operadores Aritméticos ------");
			Console.WriteLine("Soma: 10 + 20 = " + (10 + 20));
			Console.WriteLine("Subtração: 30 - 20 = " + (30 - 20));
			Console.WriteLine("Multiplicação: 10 * 20 = " + (10 * 20));
			Console.WriteLine("Divisão: 20 / 5 = " + (20 / 5));
			Console.WriteLine("Módulo - Resto da divisão: 5 % 2 = " + (5 % 2));
			numeroAtribuido++;
			Console.WriteLine("Incremento: " + numeroAtribuido);
			numeroAtribuido--;
			Console.WriteLine("Decremento: " + numeroAtribuido);
			
			/* Operadores de Comparação */
        
			Console.WriteLine("\n----- Operadores de Comparação -----");
			Console.WriteLine("5 é igual a 5: " + (5 == 5));
			Console.WriteLine("5 é diferente de 5: " + (5 != 5)); 
			Console.WriteLine("5 é maior que 4: " + (5 > 4));   
			Console.WriteLine("5 é menor que 2: " + (5 < 2));   
			Console.WriteLine("5 maior ou igual a 5: " + (5 >= 5));  
			Console.WriteLine("5 menor ou igual a 3: " + (5 <= 3));
			
			/* Operadores de Lógica */
			
			Console.WriteLine("\n------- Operadores de Lógica -------");
        
			if((5 > 2) && (5 < 8))
				Console.WriteLine("&&: As duas condições devem ser verdadeiras");
			
			if((5 > 2) || (5 < 1))
				Console.WriteLine("||: Somente uma condição deve ser verdadeira");
				
			if(!(5 < 2))
				Console.WriteLine("!:  Inverte o resultado");
			}
	}	
}