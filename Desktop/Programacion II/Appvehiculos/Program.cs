using System;
class Program
{
    List<Vehiculo> vehiculo = new List<Vehiculo>();

    static void Main ()
    {
        int opcion;

        do
        {
            Console.WriteLine("SISTEMA VEHÍCULOS");
            Console.WriteLine("1 - Registrar vehículo");
            Console.WriteLine("2 - Mostrar vehículos");
            Console.WriteLine("3 - Acciones especiales");
            Console.WriteLine("4 - Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {

                case 1:
                RegistrarVehiculo();
                break;

                case 2:
                MostrarVehiculo();
                break;

                case 3:
                AccionesEspeciales();
                break;

            }
        } while (opcion !=4);


        static void RegistrarVehiculo()
        {
            int tipo;

            Console.Write("Tipo: ");
            Console.WriteLine("1 - Auto");
            Console.WriteLine("2 - Moto");
            tipo = int.Parse(Console.ReadLine());

             
        }
    }
}