using System;

namespace Ejercicio001DeManuelPenialva
{
    class Program
    {
        static void Main(string[] args)
        {
            double CantidadDePesos, DolarOficial, DolarParalelo, Euros;
           
            Console.WriteLine(" Ingrese La Cantidad De Pesos ");
            CantidadDePesos = double.Parse(Console.ReadLine());          
           
            DolarOficial = (CantidadDePesos / 230);
            Console.WriteLine($"La Cantidad De Dolares Oficiales Que Puede Comprar Con Los Pesos Ingresados Es De {DolarOficial} Dolares Oficiales");

            DolarParalelo = (CantidadDePesos / 280);
            Console.WriteLine($"La Catidad De Dolares Paralelos Que Puede Comprar Con Los Pesos Ingresados Es De {DolarParalelo} Dolares Pralelos");
           
            Euros= DolarOficial / 1.17;
            Console.WriteLine($"El Equivalente En Euros Es {Euros} Euros");
        }
    }
}
