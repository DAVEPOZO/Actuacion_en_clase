using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Verifica tu edad para votar");
        Console.Write("Ingresa tu edad: ");

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int edad))
        {
            if (edad >= 18)
            {
                Console.WriteLine("Edad suficiente para votar.");
            }
            else
            {
                Console.WriteLine("No puedes votar con esa edad.");
            }
        }
        else
        {
            Console.WriteLine("Ingresa una edad valida.");
        }
    }
}
