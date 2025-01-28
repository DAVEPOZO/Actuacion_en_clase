using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); 

        Console.WriteLine("Adivina el numero entre el 1 y el 100");


        bool adivinado = false;
  

        // Bucle para que el usuario adivine
        while (!adivinado)
        {
            Console.Write("Ingresa tu numero: ");
            string entrada = Console.ReadLine();

            // Validar que la entrada sea un número entero
            if (int.TryParse(entrada, out int numUsuario))
            {

                if (numUsuario == numeroSecreto)
                {
                    Console.WriteLine($"Correcto El numero secreto era {numeroSecreto}");

                    adivinado = true;
                }
                else if (numUsuario < numeroSecreto)
                {
                    Console.WriteLine("El numero secreto es mayor. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("El numero secreto es menor. Intenta de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("ingresa un numero valido.");
            }
        }

    }
}
