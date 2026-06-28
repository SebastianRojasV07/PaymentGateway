using System.Collections.Generic;

public class PagoService
{
    private HashSet<string> processedKeys = new HashSet<string>();

    public bool ProcesarPago(Pago pago)
    {
        if (processedKeys.Contains(pago.IdempotenciaKey))
        {
            return false;
        }

        processedKeys.Add(pago.IdempotenciaKey);
        return true;

    }
}