public class Gato : Animal
{
    public Gato(string nombre, int edad, string raza)
    : base(nombre, edad, raza)
    {
        
    }
    public override void hacerSonido()
    {
        System.Console.WriteLine("miau");
    }

    public override void mostrarInfo()
    {
        System.Console.WriteLine("gato");
        base.mostrarInfo();
    }

    public void Ronroneo()
    {
        System.Console.WriteLine($"Gato esta ronroneando");
    }
}