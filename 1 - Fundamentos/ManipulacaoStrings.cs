using System;

namespace ManipulacaoStrings 
{
	class Program 
	{
        	static void Main(string[] args) 
		{
            
			/* Declarando uma variável do tipo string */
            		string nome = "Adriane";
			
			/* Métodos da classe string */		
			Console.WriteLine("Letras maiúsculas: " + nome.ToUpper());
			Console.WriteLine("Letras minúsculas: " + nome.ToLower());
			Console.WriteLine("Localiza a primeira ocorrência do texto passado como parâmetro: " + nome.IndexOf("ia"));
			Console.WriteLine("Contagem de caracteres: " + nome.Length);
			Console.WriteLine("1° concatenação: " + nome + " Rodrigues");
			string nomeCompleto = string.Concat(nome, " Rodrigues");
			Console.WriteLine("2° concatenação: " + nomeCompleto);
			Console.WriteLine("Obtém o caracter do índice passado como parâmetro: " + nome[2]);
			Console.WriteLine("Verifica se duas strings são iguais: " + string.Compare(nome, "adri"));
			Console.WriteLine("Substitui um caracter por outro: " + nome.Replace('a', 't'));
			Console.WriteLine("Extrair um trecho de uma string: " + nome.Substring(0, 4));
			Console.WriteLine($"Interpolação: Nome = {nome}");			
			
			string texto = "Texto com espaço no final        ";
			Console.WriteLine(texto.Trim() + " -> Remove espaços no final da string");
			
			Console.WriteLine("\nPassando valores de um array para uma string: ");
			char[] letras = {'a', 'd', 'r', 'i'};
			Console.WriteLine("Valores do array -> " + string.Join(", ", letras));
			string letrasRecebidas = "";
			letrasRecebidas = string.Join("", letras);
			Console.WriteLine("String após receber os valores -> " + letrasRecebidas);
			
			Console.WriteLine("\nSeparando a string e mandando para um array: ");
			string dados = "Nome: Adriane; Sobrenome: Rodrigues; idade: 22";
			string[] textoSeparado = dados.Split(";");
			Console.WriteLine("Dados da string no array -> " + string.Join(", ", textoSeparado));
			
			/* Escape de caracteres especiais */
            		/*
                		' -> \'
                		" -> \"
                		\ -> \\
            		*/
        	}
    	}
}