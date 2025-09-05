namespace ejercicio2
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Ingresa un número entero positivo: ");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("⚠️ Debes ingresar un número entero positivo.");
                }
                else
                {
                    int suma = 0;
                    int i = 1;

                    while (i <= n)
                    {
                        suma += i;
                        i++;
                    }

                    Console.WriteLine($"La suma de los primeros {n} números naturales es: {suma}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Debes ingresar un número entero válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
    }
}
    

