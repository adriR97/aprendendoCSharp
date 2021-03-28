using System;

namespace TiposDeDados 
{
	class Program 
	{
		static void Main(string[] args)
		{
			
			/* Tipos Primitivos */
			byte b = 127;
			short s = 32767;
			char c = 'A';
			float f = 4.6f;
			double NumeroDecimal = 2.7;
			int numeroInteiro = 4821;
			long l = 3784923618734863L;
			bool aprovado = true;	
			
			/* Tipos por referência */
			string nome = "Adriane Rodrigues";
			int[] numeros = new int[5];
			
			/*  achando o mínimo e o máximo aceito pelo int,
				pode ser utilizado em outros tipos de dados */
			int numeroMinimo = int.MinValue; 
			int numeroMaximo = int.MaxValue;
			
		}
	}	
}