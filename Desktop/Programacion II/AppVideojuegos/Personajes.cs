using System;

namespace Videojuego
{
    public abstract class Personaje
    {
        public string Nombre { get; set;}
        public int Vida {get; set;}
        public int Defensa {get; set;}

        static int TotalPersonajes = 0;

        public Personaje (string Nombre, int Vida, int Defensa)
        {

            this.Nombre = Nombre;
            this.Vida = Vida;
            this.Defensa = Defensa;
            
            TotalPersonajes++;
        }

        public static int EstadisticaPersonaje()
        {
            return TotalPersonajes;
        }

        public void Defender()
        {
            System.Console.WriteLine($"{Nombre} se defiende");
        }

        public abstract void Atacar();

        public abstract void Habilidad();

        public virtual void MostrarEstadisticas()
        {
            System.Console.WriteLine($"Nombre: {Nombre}");
            System.Console.WriteLine($"Vida: {Vida}");
            System.Console.WriteLine($"Defesa: {Defensa}");
        }            
        
    }
}