using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //===Array sirve para almacenar varios valores
            //==Con enteros
            int[] notas = { 15, 12, 4, 7, 8, 9 };
            Console.WriteLine("total de notas " + notas.Length);
            Console.WriteLine("primera nota " + notas[1]);

            //=== DINAMICO ===
            Console.WriteLine("La ultima nota: " + notas[notas.Length-1]);

            //=== ESTATICO ===
            //Console.WriteLine("Ultima nota es " + notas[5]);


            //string[] nombres = { "Jose", "Daniel", "Miguel" };

            ////Indice
            //Console.WriteLine("El numero de elementos son: " + nombres.Length);
            //Console.WriteLine("El primer Nombre es: " + nombres[1]);
            //Console.WriteLine("El segundo nombre es: " + nombres[0]);

            //===Cuando cuentas longitud inicia en 1.
            //===cuando es indice inicia en 0

            Console.ReadLine();




            //for (int i = 1; i <= 100; i++)
            //{
            //    if( (i%3)== 0 && (i % 5) == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //        //Console.WriteLine("TresCinco");

            //    }
            //    else if ((i % 3)==0 )
            //    {
            //        Console.WriteLine($"{i}");
            //        //Console.WriteLine("TRES");
            //    }
            //    else if ((i % 5) == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //        //Console.WriteLine("CINCO");
            //    }
            //    else
            //    {
            //        Console.WriteLine( $"{i}");
            //    }

            //}


        }
    }
}
