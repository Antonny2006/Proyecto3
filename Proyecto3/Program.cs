// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Mostrar el menú de opciones
        Console.WriteLine("Seleccione un operador:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        // Leer la opción seleccionada
        int opcion = Convert.ToInt32(Console.ReadLine());

        // Leer los dos números
        Console.WriteLine("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double suma = (num1 + num2);
        double resta = (num1 - num2);
        double division = (num1 / num2);
        double multiplicacion = (num1 * num2);

        if (opcion == 1)
        {
            Console.WriteLine("El resultado de la suma es " + suma);
        }
        if (opcion == 2)
        {
            Console.WriteLine("El resultado de la resta es " + resta);
        }
        if (opcion == 3)
        {
            Console.WriteLine("El resultado de la multiplicacion es " + multiplicacion);
        }
        if (opcion == 4)
        {
            Console.WriteLine("El resultado de la division es " + division);
        }
    }

}