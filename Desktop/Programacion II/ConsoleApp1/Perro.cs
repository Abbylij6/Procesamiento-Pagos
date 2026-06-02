public class Perro : Animal
{
    public Perro(string nombre, int edad, string raza)
    : base(nombre, edad, raza)
    {
        
    }
    public override void hacerSonido()
    {
        System.Console.WriteLine("guau");
    }

    public override void mostrarInfo()
    {
        System.Console.WriteLine("perro");
        base.mostrarInfo();
    }

    public void DarPatita()
    {
        System.Console.WriteLine($"Perro esta dando la patita");
    }
}