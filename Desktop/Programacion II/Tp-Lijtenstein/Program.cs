using System;

class Ejercicio1
 {
    static void Main()
    {
        Console.WriteLine("Cantidad de alumnos: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0 ; i < cantidad; i++)
        {
            Console.Write("Nombre: ");
            String nombre = Console.ReadLine();

            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double promedio = calcularPromedio (n1, n2, n3);      
            
            Console.WriteLine ($"Alumno: {nombre}");
            Console.WriteLine ($"Promedio: {promedio}");

            if (promedio >=6)
            {
                Console.WriteLine ("Aprobado");
            }
            else
            {
                Console.WriteLine ("Desaprobado");
            }
            
        }
    }

    static double calcularPromedio (double a, double b, double c)
    {
        return (a + b + c) / 3;
    }  
}

class Ejercicio2
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        
        Console.Write("cantidad: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine($"promedio: {promedio(numeros)}");
        Console.WriteLine($"Mayor: {Mayor(numeros)}");
        Console.WriteLine($"Menor: {Menor(numeros)}");
    }

    static double promedio(List<int> lista)
    {
        int suma = 0;
        foreach (int num in lista)
        {
            suma += num;
        }

        return (double) suma / lista.Count;
    }

    static int Mayor(List<int> lista)
    {
        int mayor = lista[0];
        foreach (int num in lista)
        {
            if (num > mayor) mayor = num;
        }

        return mayor;
    }

    static int Menor (List<int> lista)
    {
        int menor = lista[0];
        foreach (int num in lista)
        {
            if (num < menor) menor = num;
        }

        return menor;
    }
}

class Ejercicio3
{
    static void Main()
    {     
        List<int> numeros = new List<int>();
        int num;

        Console.Write("Ingresa numeros. 0 para finalizar: ");

        do
        {
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numeros.Add(num);
            }

        } while ( num != 0);

        List<int> pares = filtrarPares (numeros);
        
        Console.Write("Lista Original: ");
        MostrarLista(numeros);

        Console.Write("Lista Pares: ");
        MostrarLista(pares);

        if (numeros.Count == 0)
        {
             Console.WriteLine("no se ingresaron numeros");
        }

    }

    static List<int> filtrarPares (List<int> lista)
    {
        List<int> pares = new List<int>();
        
        foreach (int n in lista)
        {
            if ( n % 2 == 0)
            {
                pares.Add(n);
            }
        }

        return pares;
    }

    static void MostrarLista(List<int> lista)
    {
        foreach (int n in lista)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();

    }
}

class Ejercicio4
{
    static void Main()
    {
        List<string> nombres = new List<string>();
        List<double> promedios = new List<double>();

        Console.Write("cantidad de alumnos: ");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("nombre: ");
            string nombre = Console.ReadLine();
            nombres.Add(nombre);

            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double promedio = CalcularPromedio(n1, n2, n3);
            promedios.Add(promedio);
        }

        Console.WriteLine("Aprobados:");
        MostrarAprobados (nombres, promedios);

        Console.WriteLine("Desaprobados:");
        Mostrardesaprobados (nombres, promedios);

    }

    static double CalcularPromedio(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }

    static void MostrarAprobados(List<string> nombres, List<double> promedios)
    {
        for (int i = 0; i< nombres.Count; i++)
        {
            if (promedios[i]>= 6)
            {
                Console.WriteLine(nombres[i] + " - " + promedios[i]);
            }
        }
    }

    static void Mostrardesaprobados (List<string> nombres, List<double> promedios)
    {
        for (int i = 0; i < nombres.Count; i++)
        {
            if(promedios[i] < 6)
            {
                Console.WriteLine(nombres[i] + " - " + promedios[i]);
            }
        }
    }
}

class Ejercicio5
{
    static void Main()
     {
        List<int> notas = new List<int>();
        int opcion;

        do
        {
            Console.WriteLine("1. Agregar nota");
            Console.WriteLine("2. Mostrar notas");
            Console.WriteLine("3. Mostrar promedio");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                AgregarNota(notas);
                break;

                case 2:
                MostrarNotas(notas);
                break;

                case 3:
                MostrarPromedio(notas);
                break;

                case 4:
                Console.WriteLine("Saliendo al menu principal");
                break;

                default:
                Console.WriteLine("Opcion invalida... ingrese una opcion del menu");
                break;
                
            }

        } while (opcion !=4);
    }

    static void AgregarNota(List<int> lista)
    {
        Console.Write("ingrese una nota: ");
        int nota = int.Parse(Console.ReadLine());
        lista.Add(nota);
    }

    static void MostrarNotas(List<int> lista)
    {
        Console.Write("notas");

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }

    static void MostrarPromedio(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay notas cargadas");
            return;
        }

        int suma = 0;

        for (int i = 0; i < lista.Count; i++)
        {
            suma += lista[i];
        }

        double promedio = (double)suma / lista.Count;

        Console.WriteLine("Promedio: " + promedio);
    }
}

class Ejercicio6
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int num;

        Console.WriteLine("Ingresar números (0 para terminar):");

        do
        {
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numeros.Add(num);
            }

        } while (num != 0);

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        int posicion = BuscarNumero(numeros, buscar);

        if (posicion != -1)
        {
            Console.WriteLine("Se encontró en la posición: " + posicion);
        }
        else
        {
            Console.WriteLine("No se encontró el número");
        }
    }

    static int BuscarNumero(List<int> lista, int numero)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] == numero)
            {
                return i;
            }
        }

        return -1;
    }   
    
}

class Ejercicio7
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int num;

        Console.WriteLine("Ingresar números (0 para terminar):");

        do
        {
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numeros.Add(num);
            }

        } while (num != 0);

        Console.Write("Número a eliminar: ");
        int eliminar = int.Parse(Console.ReadLine());

        bool resultado = EliminarNumero(numeros, eliminar);

        if (resultado)
        {
            Console.WriteLine("Número eliminado.");
        }
        else
        {
            Console.WriteLine("No se encontró el número.");
        }

        Console.WriteLine("Lista actualizada:");

        for (int i = 0; i < numeros.Count; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }

    static bool EliminarNumero(List<int> lista, int numero)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] == numero)
            {
                lista.RemoveAt(i);
                return true;
            }
        }

        return false;
    }
}

class Ejercicio8
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int num;

        Console.WriteLine("Ingresar números (0 para terminar):");

        do
        {
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numeros.Add(num);
            }

        } while (num != 0);

        Console.WriteLine("Lista original:");
        MostrarLista(numeros);

        OrdenarBurbuja(numeros);

        Console.WriteLine("Lista ordenada:");
        MostrarLista(numeros);
    }

    static void OrdenarBurbuja(List<int> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            for (int j = 0; j < lista.Count - 1; j++)
            {
                if (lista[j] > lista[j + 1])
                {
                    int aux = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = aux;
                }
            }
        }
    }

    static void MostrarLista(List<int> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i] + " ");
        }
        Console.WriteLine();
    }
}

class Ejercicio9
{
    static void Main()
    {
        List<string> nombres = new List<string>();
        List<double> precios = new List<double>();

        int cantidad;

        Console.Write("Cantidad de productos: ");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Nombre del producto: ");
            nombres.Add(Console.ReadLine());

            Console.Write("Precio: ");
            precios.Add(double.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\nProductos cargados:");
        MostrarProductos(nombres, precios);

        double total = CalcularTotal(precios);
        Console.WriteLine("Total de la compra: " + total);
    }

    static void MostrarProductos(List<string> nombres, List<double> precios)
    {
        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine(nombres[i] + " - $" + precios[i]);
        }
    }

    static double CalcularTotal(List<double> precios)
    {
        double suma = 0;

        for (int i = 0; i < precios.Count; i++)
        {
            suma += precios[i];
        }

        return suma;
    }
}

class Ejercicio10
{
    static void Main()
    {
        List<double> temperaturas = new List<double>();
        double temperatura;

        Console.WriteLine("Ingresar temperaturas (0 para terminar):");

        do
        {
            temperatura = double.Parse(Console.ReadLine());

            if (temperatura != 0)
            {
                temperaturas.Add(temperatura);
            }

        } while (temperatura != 0);

        double promedio = CalcularPromedio(temperaturas);
        double max = ObtenerMaxima(temperaturas);
        double min = ObtenerMinima(temperaturas);
        int posicionMax = PosicionMaxima(temperaturas);

        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Temperatura máxima: " + max);
        Console.WriteLine("Temperatura mínima: " + min);
        Console.WriteLine("Posición de la máxima: " + posicionMax);
    }

    static double CalcularPromedio(List<double> lista)
    {
        double suma = 0;

        for (int i = 0; i < lista.Count; i++)
        {
            suma += lista[i];
        }

        return lista.Count > 0 ? suma / lista.Count : 0;
    }

    static double ObtenerMaxima(List<double> lista)
    {
        double max = lista[0];

        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] > max)
            {
                max = lista[i];
            }
        }

        return max;
    }

    static double ObtenerMinima(List<double> lista)
    {
        double min = lista[0];

        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] < min)
            {
                min = lista[i];
            }
        }

        return min;
    }

    static int PosicionMaxima(List<double> lista)
    {
        double max = lista[0];
        int posicion = 0;

        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] > max)
            {
                max = lista[i];
                posicion = i;
            }
        }

        return posicion;
    }
}