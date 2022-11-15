using System;

namespace Estructuras_Repetitivas
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Acumuladores Contadores
            //int d = 28;

            //Aumenta el valor de la variable
            //d++;
            // d = d + 10;
            //Console.WriteLine("El valor es: " + d );

            // 22.While 
            //int i = 20;
            //while(i <= 105)
            //{
            //    Console.WriteLine(i);
            //    i = i + 5;


            //}

            ///23.While 1
            //int con = 1;
            //string cadenaNumero;
            //int numero, suma = 0;

            //while(con <= 5)
            //{
            //    Console.WriteLine("Ingrese numero" + con);
            //    cadenaNumero = Console.ReadLine();
            //    numero = int.Parse(cadenaNumero);
            //    suma += numero;
            //    con++;

            //}
            //Console.WriteLine("Suma es: " + suma);

            ///24.While 2
            //int numero, numeroTriple;
            //string numeroCadena;

            //Console.WriteLine("Ingrese un numero");
            //numeroCadena = Console.ReadLine();
            //numero = int.Parse(numeroCadena);
            //numeroTriple = numero * 3;
            //Console.WriteLine("El numero Triple es: " + numeroTriple);
            ////numero es diferente de 0
            //while(numero != 0)
            //{
            //    Console.WriteLine("Ingrese otro numero");
            //    numeroCadena = Console.ReadLine();
            //    numero = int.Parse(numeroCadena);
            //    numeroTriple = numero * 3;
            //    Console.WriteLine("El numero Triple es: " + numeroTriple);

            //}
            //Console.WriteLine("Finalizo");


            ///25.Ejercicio While 3(Uso del Break)
            ///
            //string numeroCadena;
            //int numero;
            //Console.WriteLine("Ingrese un numero");
            //numeroCadena = Console.ReadLine();
            //numero = int.Parse(numeroCadena);
            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("Par");
            //}
            //else
            //{
            //    Console.WriteLine("Impar");
            //}
            //while (numero >= 0)
            //{
            //    Console.WriteLine("Ingrese Numero");
            //    numeroCadena = Console.ReadLine();
            //    numero = int.Parse(numeroCadena);
            //    //Uso del break, sale del bucle
            //    if (numero < 0) break;


            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("Par");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Impar");
            //    }
            //}
            //Console.WriteLine("Finalizo");


            //26. Do while
            ///Ingresar numeros hasta que el numero negativa

            //int numero, i = 1;
            //int contador = 0;
            //string numCadena;

            //do
            //{
            //    Console.WriteLine("Ingrese numero: "+ i);
            //    numCadena = Console.ReadLine();
            //    numero = int.Parse(numCadena);
            //    i++;
            //    contador++;

            //} while (numero >= 0);
            //Console.WriteLine("Numero Positivos: " + (contador-1));
            //Console.WriteLine("Finalizado");


            //27.Estructura For

            //for (int i = 1; i<= 20; i++)
            //{
            //    Console.WriteLine("Hola a todos");

            //}

            //28.Tabla de multiplicar 

            //for (int i = 1; i <= 12; i++)
            //{
            //    int resultado = 8 * i;
            //    Console.WriteLine("2x " + i + " = " + resultado);

            //}


            //29.Ejercicio Numero Listado Pares
            //Console.WriteLine("Ingrese rango 1");
            //int rango1= int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese rango 2");
            //int rango2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("****************");

            //for (int i = rango1; i <= rango2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            ///====== EJERCICIOS POR REALIZAR =======///
            //1.Imprimir los números del 19 al 37 , de 2 en 2(con While)

            //int val = 19;

            //while (val <= 37)
            //{
            //    Console.WriteLine(val);
            //    val = val + 2;

            //}

            //2.Imprimir la mitad de un numero , hasta que se ingrese un numero negativo .Usar el Do While

            //int numero;
            //int val = 1;
            //int contador = 0;
            //string numeroCadena;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero" + val);
            //    numeroCadena = Console.ReadLine();
            //    numero = int.Parse(numeroCadena);
            //    numero++;
            //    contador++;

            //} while (numero >= 0);
            //Console.WriteLine("Numero positivos "+(contador-1));
            //Console.WriteLine("Finalizado");



        }
    }
}
