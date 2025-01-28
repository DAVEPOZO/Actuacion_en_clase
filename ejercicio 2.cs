using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Por favor, ingresa tu edad: ");

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int edad))
        {
            if (edad >= 18)
            {
                Console.WriteLine("Puedes votar");
            }
            else
            {
                Console.WriteLine("No puedes votar. Debes tener minimo 18 ");
            }
        }
        else
        {
            Console.WriteLine("ingresa un numero valido para la edad.");
        }
    }
}
