using System;

    class Abril
    {
        static void Main()
        {
            /* //CLASE 09/4
            //Ejercicio 4: Atención en un hospital  // En un hospital se atienden pacientes según gravedad.

            // Requerimientos:
            // Usar:         // Cola para pacientes comunes        // Pila para emergencias        // Cada paciente tiene:
            // Nombre        // Nivel de gravedad (alta o baja)   // Atender:   // Primero emergencias    // Luego comunes

            // 👉 Extra:  // Registrar en un diccionario:  // clave = nombre  // valor = cantidad de veces atendido

            Queue<string> cola = new Queue<string>();
            Stack<string> pila = new Stack<string>();
            Dictionary< string, int> pacientes = new Dictionary<string, int>();

            int opcion;

            do
            {
                Console.WriteLine("1 . agregar paciente");
                Console.WriteLine("2 . atender paciente");
                Console.WriteLine("3 . ver pacientes");
                Console.WriteLine("4 . salir");
                Console.Write("opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    Console.Write("nombre del paciente: ");
                    string nombre = Console.ReadLine();

                    Console.Write("gravedad (Alta/baja): ");
                    string gravedad = Console.ReadLine().ToLower();

                    if(gravedad == "alta")
                        {
                            pila.Push (nombre);
                        }
                        else
                        {
                            cola.Enqueue (nombre);
                        }
                        break;

                    case 2:
                        string atendido = "";

                        if (pila.Count > 0)
                        {
                            atendido = pila.Pop();

                        }
                        else if (cola.Count > 0)
                        {
                            atendido = cola.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("no hay pacientes");
                            break;

                        }

                        Console.WriteLine ($"atendiendo a: {atendido}");

                        if(pacientes.ContainsKey(atendido))
                        {
                            pacientes[atendido]++;
                        }
                        else
                        {
                            pacientes[atendido] = 1;
                        }
                    
                    break;

                    case 3:
                        Console.WriteLine("ver paciente:");
                        foreach (var a in pacientes)
                        {
                            Console.WriteLine(a.Key + ": " + a.Value);
                        }
                    break;
                }
            }while (opcion !=4); */

            // Clase 14/04: POO
            // Programacion orientada a objetos: estilo de programar - Clases (molde) tipo de plantillas que define artibutos y metodos
            // objeto: instancia de la clase (reproduccion del molde) - metodo : accion del objeto
            // crear otro archivo y crear public class {nombre} ()
            // crear caracteristicas del objeto (string/int/bool) agregar las que me haga falta
            // "this" palabra clave - 

            //Clase 21/04
            //cliente: FitnessPro
            //programa: un sistema par aun gimnasio - administrar inscripciones

            
        }
    }