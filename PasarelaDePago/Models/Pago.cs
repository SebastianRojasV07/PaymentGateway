using System;

public class Pago
{
    public decimal Monto { get; set; }

    public string IdempotenciaKey { get; set; } = string.Empty;
}
