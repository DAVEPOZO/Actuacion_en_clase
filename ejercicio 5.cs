using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer numero: ");
        
        
        string entrada1 = Console.ReadLine();

        Console.Write("Ingresa el segundo numero: ");
        
        string entrada2 = Console.ReadLine();

        if (double.TryParse(entrada1, out double numero1) && double.TryParse(entrada2, out double numero2))
        {
       
            if (numero1 > numero2)
            {
                Console.WriteLine($"El numero mayor es: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El numero mayor es: {numero2}");
            }
            else
            {
                Console.WriteLine("Ambos numeros son iguales.");
            }
        }
        else
        {
            Console.WriteLine("Ingresa numeros que sean correctos.");
        }
    }
}
