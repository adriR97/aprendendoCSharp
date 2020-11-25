using System;

namespace EntradaSaidaDeDados {
	class Program {
		static void Main(string[] args){
			Console.Write("Nome: ");             // sem quebra de linha
			string nome = Console.ReadLine();
			Console.WriteLine(nome);             // com quebra de linha
		}
	}	
}