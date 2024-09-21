using System;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos 
            //y luego mostrar por pantalla el menor de ellos.

            //Paso 0: Crear Variables
            int N1, N2, N3, N4, MENOR;

            //Paso 1: Pedir Numeros
            Console.WriteLine("Ingrese 1er numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 2do numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 3er numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 4to numero: ");
            N4 = int.Parse(Console.ReadLine());

            //Paso 2: Condiciones
            MENOR = N1;
            if(N2 < MENOR)
                MENOR=N2;

            if(N3 < MENOR)
                MENOR = N3;
//
            if(N4 < MENOR)
                MENOR = N4;

            Console.WriteLine("El Menor Numero Ingresado es: " + MENOR);

            Console.WriteLine("FIN DEL PROGRAMA");

        }
    }
}
