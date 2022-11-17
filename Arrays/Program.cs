using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ///24.While 2
            int numero, numeroTriple;
            string numeroCadena;

            Console.WriteLine("Ingrese un numero");
            numeroCadena = Console.ReadLine();
            numero = int.Parse(numeroCadena);
            numeroTriple = numero * 3;
            Console.WriteLine("El numero Triple es: " + numeroTriple);
            //numero es diferente de 0
            while (numero != 0)
            {
                Console.WriteLine("Ingrese otro numero");
                numeroCadena = Console.ReadLine();
                numero = int.Parse(numeroCadena);
                numeroTriple = numero * 3;
                Console.WriteLine("El numero Triple es: " + numeroTriple);

            }
            //cierre
            Console.WriteLine("Finalizo");

        }
    }
}
