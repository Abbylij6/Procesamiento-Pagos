using System;

    class Program
{   
    static List<Animal> animales = new List<Animal>();
    static void Main()
    {
     int opcion;
     do
        {
            Console.WriteLine("menu");
            System.Console.WriteLine("1. registrar animales");
            System.Console.WriteLine("2. mostrar animales");
            System.Console.WriteLine("3. acciones");
            System.Console.WriteLine("4. salir");
            System.Console.WriteLine("opcion: ");
            
            opcion = int.Parse(System.Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                registrarAnimales();
                break;

                case 2: 
                mostrarAnimales();
                break;

                
                case 3:
                acciones();
                break;

                
            }

        } while(opcion != 4);

    }

    static void registrarAnimales()
        {
            System.Console.WriteLine("1. gato");
            System.Console.WriteLine("2. perro");
            System.Console.WriteLine("seleccionar el tipo de animal");
            int tipo = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("nombre:  ");
            string nombre = Console.ReadLine();
            System.Console.WriteLine("edad:  ");
            int edad = int.Parse(Console.ReadLine());
            System.Console.WriteLine("raza:  ");
            string raza = Console.ReadLine();

            switch (tipo)
            {
                case 1: 
                animales.Add(new Gato(nombre, edad, raza));
                System.Console.WriteLine("animal registrado");
                break;

                case 2:
                animales.Add(new Perro(nombre, edad, raza));
                System.Console.WriteLine("animal registrado");
                break;

                default: 
                System.Console.WriteLine("opcion invalida");
                break;
            }
        }

    static void mostrarAnimales()
        {
            foreach(var animal in animales)
            {
                animal.mostrarInfo();
                animal.hacerSonido();


            }
            System.Console.WriteLine($"total animales: {Animal.ObtenerTotal()}");

        }

     static void acciones()
        {
            foreach(var animal in animales)
            {
                if(animal is Perro perro)
                {
                    perro.DarPatita();
                }
                else if(animal is Gato gato)
                {
                    gato.Ronroneo();
                }

            }
        } 
}
