
PagoService pagoService = new PagoService();
Pago pago1 = new Pago();
Pago pago2 = new Pago();

pago1.Monto = 150;
pago1.IdempotenciaKey = "ABC123";
MostrarResultado(pago1);
MostrarResultado(pago1);

void MostrarResultado(Pago pago)
{
    if (pagoService.ProcesarPago(pago))
    {
        Console.WriteLine($"Pago de {pago.Monto} procesado correctamente.");
    }
    else
    {
        Console.WriteLine("Este pago ya fue procesado.");
    }
}
