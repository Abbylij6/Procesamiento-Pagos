public abstract class Animal
{
    private string nombre;
    private int edad;
    private string raza;

    public string Nombre {get{return this.nombre;} set{this.nombre=value;}}
    public int Edad{get{return this.edad;} set{this.edad=value;}}
    public string Raza {get{return this.raza;} set{this.raza=value;}}
    private static int totalAnimales = 0;

    public Animal(string nombre, int edad, string raza)
    {
        Nombre = this.Nombre;
        Edad = this.Edad;
        Raza = this.Raza;

        totalAnimales++;
    }

    public static int ObtenerTotal()
    {
        return totalAnimales;
    }

    public abstract void hacerSonido();
    
    public virtual void mostrarInfo()
    {
        System.Console.WriteLine($"nombre: {Nombre}");
        System.Console.WriteLine($"edad: {Edad}");
        System.Console.WriteLine($"raza: {Raza}");
    }
}