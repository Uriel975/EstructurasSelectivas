using System;

namespace EstructurasSelectivas
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ====Ejercicios de practica==== ///
            //MULTIPLOS DE 5//
            //Console.WriteLine("Ingrese un numero");
            //string numeroCadena = (Console.ReadLine());
            //int numero = int.Parse(numeroCadena);
            //if (numero % 5 == 0)
            //{
            //    Console.WriteLine("Es multiplo de 5");
            //}
            //else
            //{
            //    Console.WriteLine("No es multiplo de 5");
            //}
            //Console.ReadLine();

            // ==EJERCICIO 2=== ///
            //Console.WriteLine("Indique las horas trabajadas");
            //string horaCadena = Console.ReadLine();
            //int hora = int.Parse(horaCadena);
            //double precio;
            //if (hora >= 30)
            //{
            //    precio = 20;

            //}
            //else
            //{
            //    precio = 10;

            //}
            //double total = hora * precio;
            //Console.WriteLine("El total es: " + total);
            //Console.ReadLine();

            //EJERCICIO 3
            //Console.WriteLine("Ingrese el primer numero: ");
            //string cadenaNumero1 = Console.ReadLine();
            //decimal numero1 = decimal.Parse(cadenaNumero1);
            //Console.WriteLine("Ingrese un segundo numero: ");
            //string cadenaNumero2 = Console.ReadLine();
            //decimal numero2 = decimal.Parse(cadenaNumero2);
            //Console.WriteLine("Ingrese un caracter + , - , * o /");
            //string operacion = Console.ReadLine();
            //decimal resultado = 0;
            //switch (operacion)
            //{

            //    case "+": resultado = numero1 + numero2; break;
            //    case "-": resultado = numero1 - numero2; break;
            //    case "*": resultado = numero1 * numero2; break;
            //    case "/": resultado = numero1 / numero2; break;
            //    default: Console.WriteLine("Ocurrio un error :( , ingreso letra equivocada"); break;

            //}
            //Console.WriteLine("El resultado es: " + resultado);
            //Console.ReadLine();



            //20.Ejercicio Switch
            //Console.WriteLine("Ingrese sueldo: ");
            //int sueldo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese categoria: ");
            //string categoria = Console.ReadLine();
            //int aumento;
            //switch (categoria)
            //{
            //    case "A": aumento = 500;break;
            //    case "B": aumento = 300;break;
            //    case "C": aumento = 200;break;
            //    default: aumento = 10;break;

            //}
            //int TotalAPagar = sueldo + aumento;
            //Console.WriteLine("Aumento" + aumento);
            //Console.WriteLine("Total a pagar " + TotalAPagar);

            //19.Estructura Switch
            //Console.WriteLine("Ingrese un numero del 1 al 7: ");
            //int numero = int.Parse(Console.ReadLine());
            //switch (numero)
            //{
            //    case 1: Console.WriteLine("Lunes");break;
            //    case 2: Console.WriteLine("Martes");break;
            //    case 3: Console.WriteLine("Miercoles");break;
            //    case 4: Console.WriteLine("Jueves"); break;
            //    case 5: Console.WriteLine("Vieres"); break;
            //    case 6: Console.WriteLine("Sabado"); break;
            //    case 7: Console.WriteLine("Domingo");break;
            //    default:Console.WriteLine("Error"); break;
            //}
            //Console.ReadKey();



            //18.Estructura Switch
            //Console.WriteLine("Ingrese una nota: ");
            //string nota = Console.ReadLine();
            //switch (nota)
            //{
            //    case "A": Console.WriteLine("Aprobo");break;
            //    case "B": Console.WriteLine("Aprobo"); break;
            //    case "C": Console.WriteLine("Aprobo"); break;
            //    default: Console.WriteLine("Error");break;
            //}

            //17. Elaborar else anidado 
            //Console.WriteLine("Ingrese una letra A , B o C ");
            //string notaCadena = Console.ReadLine();
            //if (notaCadena.Equals("A"))
            //{
            //    Console.WriteLine("El usuario Aprobo");
            //}
            //else if (notaCadena.Equals("B"))
            //{
            //    Console.WriteLine("El usuario necesita reforzamiento");

            //}
            //else if(notaCadena.Equals("C")){
            //    Console.WriteLine("El usuario desaprobo");

            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}


            //16.Es par o impar
            //Console.WriteLine("Ingrese un numero");
            //string numeroCadena = Console.ReadLine();
            //int numero = int.Parse(numeroCadena);
            //int residuo = numero % 2;
            //if (residuo.Equals(0))
            //    Console.WriteLine("Es Par");
            //else
            //    Console.WriteLine("Es impar");



            //15.Descuento
            //Console.WriteLine("Ingrese el precio :");
            //string PrecioCadena = Console.ReadLine();
            //decimal precio = decimal.Parse(PrecioCadena);
            //decimal descuento;


            //if (precio > 500)
            //{
            //    descuento = precio * 0.20m;
            //}

            //else
            //{
            //    descuento = precio * 0.10m;

            //}

            //decimal PrecioTotal = precio - descuento;
            //Console.WriteLine("Descuento: " + descuento);
            //Console.WriteLine("Precio total: " + PrecioTotal);
            //Console.ReadKey();





            //14.Ejercicio de Edad

            //Console.WriteLine("Ingrese su edad: ");
            //string edadCadena = Console.ReadLine();
            //int edad = int.Parse(edadCadena);
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Es mayo de edad");
            //}
            //else
            //{
            //    Console.WriteLine("Es menor de edad");
            //}



            //13 Estructura Selectiva (Personalizada)
            //int val1 = 200;
            //int val2 = 160;

            //if (val1 > val2)
            //{
            //    Console.WriteLine("val1 es mayor que val2");

            //}
            //else
            //{
            //    Console.WriteLine("val2 no es igual que val1");

            //}
            //if (val1 == val2)
            //{
            //    Console.WriteLine("val1 es igual que val2");

            //}


            //13 Estructura Selectiva
            /*
            if(val1 > val2)
            {
                Console.WriteLine("val1 es mayor que val2");

            }
            else
            {
                Console.WriteLine("val2 es menor que val1");
            }
            */
        }
    }
}
