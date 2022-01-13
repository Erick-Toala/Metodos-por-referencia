using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos los parametros de la primera letra y ultima letra
            char primeraLetra = '0', ultimaLetra = '0';
            //creamos la cadena de caracteres
            string cadena= "Programacion";
            //recibe una cadena y  nos devuelve la primera letra, y la última letra
            ObtenerPrimeraYUltima(cadena, ref primeraLetra, ref ultimaLetra);
            //imprimimos por pantalla
            Console.WriteLine("La primera letra es: "+ primeraLetra + "\nLa última letra es: " + ultimaLetra);
        }

        /*método que recibirá tres parámetros, un string, un caracter que será la primera letra
         y otro carácter que será la última letra */
        static void ObtenerPrimeraYUltima(string cadena, ref char primera, ref char ultima)
        {
            //primera letra va a ser igual a lo que haya en la posición cero de mi cadena
            primera = cadena[0];
            //última letra va a ser igual lo que haya en la última posición de mi cadena
            ultima = cadena[cadena.Length - 1];
        }
    }
}
