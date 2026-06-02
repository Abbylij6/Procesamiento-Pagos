public class Alumno:Persona
{
    public string Carrera { get; set;}
    
        public Alumno(string nombre,int edad, string carrera) :base (nombre, edad)
    {
        Carrera = carrera;
    }

    public override void MostrarInfo()
    {
        System.Console.WriteLine($"carrera: {Carrera}");
    }
    
}