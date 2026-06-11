public abstract class Pago
{
    public string Titular { get; set; }
    public double Monto { get; set; }

    public Pago(string titular, double monto)
    {
        Titular = titular;
        Monto = monto;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Titular: " + Titular + "n/" + 
        "Monto original: $" + Monto);
    }

    public abstract void ProcesarPago();
}