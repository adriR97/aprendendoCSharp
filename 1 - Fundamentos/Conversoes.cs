using System;

namespace Conversoes {
	class Program {
		static void Main(string[] args){
		    
		    /* Boolean para inteiro */
		    bool boolToInt = false;
            int valorInteiro = (boolToInt) ? 1 : 0;
            
            /* Inteiro para booleano */
            int intToBool = 1;
            bool valorBool = (intToBool != 0);
            
            /* Hexadecimal para inteiro */
            int valorDecimal = Convert.ToInt32("6f", 16);
            
            /* Double para String */
            double doubleToString = 3.24;
            string valorDouble = doubleToString.ToString();
            
            /* String para double */
            string stringToDouble = "43";
            double valorD = Convert.ToDouble(stringToDouble);
		    
			Console.Write(valorD);
		}
	}	
}