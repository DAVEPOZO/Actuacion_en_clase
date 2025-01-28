using System;

class Program
{
    static void Main(string[] args)
    {
 
        Console.Write("Ingresa un numero entero: ");

     
        string entrada = Console.ReadLine();
        
        if (int.TryParse(entrada, out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es impar.");
            }
        }
        else
        {
            Console.WriteLine("Ingresa un numero entero correcto.");
        }
    }
}
