using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Por favor, ingresa la calificación entre 0 y 100: ");

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int calificacion) && calificacion >= 0 && calificacion <= 100)
        {
           
            switch (calificacion / 10)
            {
                case 10:
                case 9:  
                    Console.WriteLine("La calificacion es: A");
                    break;
                case 8: 
                    Console.WriteLine("La calificacion es: B");
                    break;
                case 7:  
                    Console.WriteLine("La calificacion es: C");
                    break;
                case 6:  
                    Console.WriteLine("La calificacion es: D");
                    break;
                default: 
                    Console.WriteLine("La calificacion es: F");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ingresa una calificacion entre 0 y 100.");
        }
    }
}
