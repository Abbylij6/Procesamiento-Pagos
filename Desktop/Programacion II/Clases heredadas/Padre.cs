using System;// See https://aka.ms/new-console-template for more information

    public class Persona
{
    public string Nombre {get; set;}
    public int Edad {get; set;}
    
    public Persona (string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public virtual void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {Nombre}");
        System.Console.WriteLine($"Edad: {Edad}");
    }
}

