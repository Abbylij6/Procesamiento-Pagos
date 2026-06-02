using System;

namespace Videojuego
{
    class program
    {
        List<Personaje> personajes = new List<Personaje>();

        static void Main()
        {
            int opcion;

            do
            {
                System.Console.WriteLine("==RPG de Magos==");
                System.Console.WriteLine("1. Crear personaje");
                System.Console.WriteLine("2. Mostrar personajes");
                System.Console.WriteLine("3. Acciones");
                System.Console.WriteLine("4. Salir");

                System.Console.WriteLine("Opcion: ");
                
                opcion = int.Parse (Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearPersonaje();
                        break;

                    case 2:
                        MostrarPersonajes();
                        break;

                    case 3:
                        EjecutarAcciones();
                        break;
                }

            } while (opcion != 4);

        }
        
        static void CrearPersonaje()
        {
            
            Console.WriteLine("2 - Mago");
            Console.Write("Tipo: ");

            int tipo = int.Parse(Console.ReadLine());
            
        }
    }
}