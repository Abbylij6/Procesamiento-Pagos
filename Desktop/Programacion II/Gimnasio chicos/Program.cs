using System;


class Program
{
    static void Main()
    { 
        List<Usuario> usuarios = new List<Usuario>();

        int numero = 0;
        while(numero != 3)
        {
        Console.WriteLine("Seleccione la opcion que desea: ");
        Console.WriteLine("1. Mostrar usuarios.");
        Console.WriteLine("2. Cargar usuario: ");
        Console.WriteLine("3. Salir");
        numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                foreach(Usuario u in usuarios)
                    {
                        u.MostrarInfo();
                    }
                break;

                case 2:
                Usuario usuario = new Usuario();
                
                Inscripcion inscripcion = new Inscripcion();

                System.Console.WriteLine("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                
                Console.WriteLine("Ingrese DNI: ");
                int dni = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Ingrese tipo de suscripcion(Oro/Plata/Bronce): ");
                string suscripcion = Console.ReadLine();

                System.Console.WriteLine("Metodo de pago: ");
                string metodo = Console.ReadLine();

                inscripcion.Suscripcion = suscripcion;

                inscripcion.MetodoPago = metodo;

                usuario.Nombre = nombre;
                
                usuario.DNI = dni;

                usuario.Inscripcion = inscripcion;

                usuarios.Add(usuario);

                break;
            }
    }

  }
}