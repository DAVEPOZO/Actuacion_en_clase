using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Ingresa una calificacion (0-100): ");

     
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int calificacion))
        {
            if (calificacion >= 0 && calificacion <= 100)
            {
                string letra;

                // Determinar la calificación en letra
                if (calificacion >= 90)
                {
                    letra = "A";
                }
                else if (calificacion >= 80)
                {
                    letra = "B";
                }
                else if (calificacion >= 70)
                {
                    letra = "C";
                }
                else if (calificacion >= 60)
                {
                    letra = "D";
                }
                else
                {
                    letra = "F";
                }

                Console.WriteLine($"La calificacion {calificacion} corresponde a la letra: {letra}");
            }
            else
            {
                Console.WriteLine("Ingresa una calificacion entre 0 y 100.");
            }
        }
        else
        {
            Console.WriteLine("Ingresa un numero valido.");
        }
    }
}
