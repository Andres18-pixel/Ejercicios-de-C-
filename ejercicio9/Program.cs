namespace ejercicio9
    // Número mayor entre tres valores.
    // Solicita tres números diferentes al usuario y usa estructuras if para determinar cuál es el mayor.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor;

            if (num1 > num2 && num1 > num3)
            {
                mayor = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            Console.WriteLine("El número mayor es: " + mayor);
        }
    }
}
