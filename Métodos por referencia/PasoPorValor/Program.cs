using System;

namespace PasoPorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int resultado= duplicar(numero);
            Console.WriteLine("El valor retornado por el método es: " + resultado);
            Console.WriteLine("El valor de numero es: " + numero);

        }
        static int duplicar(int numero) 
        {
            numero = numero * 2;  
            return numero;
        }
    }
}
