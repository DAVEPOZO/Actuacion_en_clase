using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa un numero del 1 al 7: ");

        string entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int dia))
        {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes.");
                    break;
                case 2:
                    Console.WriteLine("El dia es Martes.");
                    break;
                case 3:
                    Console.WriteLine("El dia es Miércoles.");
                    break;
                case 4:
                    Console.WriteLine("El dia es Jueves.");
                    break;
                case 5:
                    Console.WriteLine("El dia es Viernes.");
                    break;
                case 6:
                    Console.WriteLine("El dia es Sábado.");
                    break;
                case 7:
                    Console.WriteLine("El dia es Domingo.");
                    break;
                default:
                    Console.WriteLine("Ingresa un numero valido entre 1 y 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ingresa un numero entero valido.");
        }
    }
}
