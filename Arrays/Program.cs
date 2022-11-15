using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 23.While 1
            int con = 1;
            string cadenaNumero;
            int numero, suma = 0;

            while (con <= 5)
            {
                Console.WriteLine("Ingrese numero" + con);
                cadenaNumero = Console.ReadLine();
                numero = int.Parse(cadenaNumero);
                suma += numero;
                con++;

            }
            Console.WriteLine("Suma es: " + suma );
        }
    }
}
