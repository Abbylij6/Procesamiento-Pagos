using System;

    Console.WriteLine();
Console.WriteLine("===== SISTEMA DE PAGOS =====");

List<Pago> pagos = new List<Pago>();

pagos.Add(new TarjetaCredito("Juan Pérez", 25000));
pagos.Add(new Transferencia("Ana López", 18000));

foreach (Pago pago in pagos)
{
    pago.MostrarInfo();
    pago.ProcesarPago();

    Console.WriteLine("--------------------------------");
}