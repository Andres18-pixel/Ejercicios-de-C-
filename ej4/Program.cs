namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número para su tabla de multiplicar (hasta 12): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Asegurarse de que el número esté entre 1 y 12
            if (numero < 1 || numero > 12)
            {
                Console.WriteLine("Por favor, ingresa un número entre 1 y 12.");
                return;
            }

            int i = 1; //
            do
            {
                Console.WriteLine($"{i} x {numero} = {i * numero}");
                i++;
            } while (i <= 12);
        }
    }
}
