using System;

namespace Videojuego
{
    public class Mago:Personaje
    {
        public int mana {get; set;}

        public Mago (string Nombre, int Vida, int Defensa, int Mana)
        : base (Nombre,Vida, Defensa)
        {
            Mana = mana;        
        }

        public override void Atacar()
        {
            System.Console.WriteLine($"{Nombre} lanzar una bola de rayo");
        }

        public override void Habilidad()
        {
            System.Console.WriteLine($"{Nombre} Usa Hechizo magico");
        }

        public override void MostrarEstadisticas()
        {
            System.Console.WriteLine("==MAGO==");
            System.Console.WriteLine($"Mana: {mana}");
            System.Console.WriteLine($"Vida: {Vida}");
        }

        public void Volar()
        {
            System.Console.WriteLine($"{Nombre} se ha puesto a Volar");
        }
    }
}