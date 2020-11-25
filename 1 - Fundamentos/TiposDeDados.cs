using System;

namespace TiposDeDados {
	class Program {
		static void Main(string[] args){
			bool verdadeiro = false;
			char genero = 'F';
			int numero = 345;
			float numeroDecimal = 4.7f;    //colocar o f pq senão identifica como double
			double numeroDecimal2 = 4.7;
			string nome = "Adriane";
			
			/*  achando o mínimo e o máximo aceito pelo int,
				pode ser utilizado em outros tipos de dados */
			int numeroMinimo = int.MinValue; 
			int numeroMaximo = int.MaxValue;
		}
	}	
}