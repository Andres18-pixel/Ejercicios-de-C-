namespace ejercicio3
{ // Menú de opciones (switch).
  // Crea un menú simple con opciones como:
  // Saludar
  // Mostrar la fecha actual
  // Salir.
  // Usa switch para ejecutar la opción seleccionada por el usuario.
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("===== MENÚ DE OPCIONES =====");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Mostrar la fecha actual");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¡Hola! Espero que tengas un excelente día.\n");
                        break;

                    case 2:
                        Console.WriteLine("La fecha y hora actual es: " + DateTime.Now + "\n");
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.\n");
                        break;
                }
            } while (opcion != 3);
        }
    }
}
