using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Formas de definir un Array y Matrices*/
            int[] Notas = new int[5];
            Notas[0] = 10;
            Notas[1] = 20;
            Notas[2] = 30;
            Notas[3] = 40;
            Notas[4] = 50;
            foreach (int Lista in Notas)
            {
                Console.WriteLine(Lista);
            }




            //int[] notas = { 10, 11, 12, 15, 21 };
            //foreach(int not in notas)
            //{
            //    Console.WriteLine(not);
            //}

            //Video 32 ( Recorrer todo el array)
            //string[] nombres = { "Luis", "Manuel", "Eduardo" };

            /*Forma 1*/
            //int nelementos = nombres.Length;
            //for (int i = 0; i < nelementos; i++)
            //{
            //    Console.WriteLine(nombres[i]);
            //}

            /*Forma 2*/
            //foreach(string nom in nombres)
            //{
            //    Console.WriteLine(nom);
            //}












            //===Array sirve para almacenar varios valores
            //==Con enteros
            //int[] notas = { 15, 12, 4, 7, 8, 9 };
            //Console.WriteLine("total de notas " + notas.Length);
            //Console.WriteLine("primera nota " + notas[1]);

            //=== DINAMICO ===
            //Console.WriteLine("La ultima nota: " + notas[notas.Length-1]);

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
