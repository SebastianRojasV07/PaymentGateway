
PagoService pagoService = new PagoService();
Pago pago1 = new Pago();
Pago pago2 = new Pago();

pago1.Monto = 150;
pago1.IdempotenciaKey = "ABC123";

pago2.Monto = 200;
pago2.IdempotenciaKey = "XYZ789";

pagoService.ProcesarPago(pago1);
pagoService.ProcesarPago(pago2);
pagoService.ProcesarPago(pago1);
pagoService.ProcesarPago(pago2);
