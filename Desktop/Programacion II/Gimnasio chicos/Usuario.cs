public class Usuario
{
    private string nombre;
    private int dni;

    private Inscripcion? inscripcion;

    public string Nombre {get {return this.nombre;} set {this.nombre = value;}}
    public int DNI {get {return this.dni;} set {this.dni = value;}}

    public Inscripcion Inscripcion {get{return this.inscripcion;} set {this.inscripcion = value;}}
    // public Inscripcion inscripcion1(string suscripcion, string metodoPago)
    // {
    //     Inscripcion NuevaInscripcion = new  Inscripcion();
    //     NuevaInscripcion.Suscripcion = suscripcion;
    //     NuevaInscripcion.MetodoPago = metodoPago;
        

    //     return NuevaInscripcion;
    // }    
    public void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {Nombre}");
        System.Console.WriteLine($"DNI: {DNI}");
        System.Console.WriteLine($"Inscripcion: {this.Inscripcion.Suscripcion}");
        
    }
}