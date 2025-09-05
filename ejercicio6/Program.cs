namespace ejercicio6
{// Número positivo o negativo.
 // Solicita un número al usuario e indica si es positivo, negativo o cero usando una estructura if.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
    }
}
