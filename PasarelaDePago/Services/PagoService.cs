using System.Collections.Generic;

public class PagoService
{
    private HashSet<string> processedKeys = new HashSet<string>();

    public void ProcesarPago(Pago pago)
    {
        if (processedKeys.Contains(pago.IdempotenciaKey))
        {
            Console.WriteLine("Este pago ya fue procesado");
            return;
        }

        processedKeys.Add(pago.IdempotenciaKey);
        Console.WriteLine($"Pago de {pago.Monto} procesado correctamente.");
    }
}