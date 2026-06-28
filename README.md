# PaymentGateway

## Descripción

Simulación de una pasarela de pagos que implementa idempotencia mediante una Idempotency Key.

## Tecnologías

- C#
- .NET Console

## ¿Qué problema resuelve?

Evita que un mismo pago sea procesado más de una vez cuando el cliente reintenta una solicitud.

## Funcionamiento

1. El cliente envía un monto y una Idempotency Key.
2. Si la clave no existe, el pago se procesa y la clave se almacena.
3. Si la clave ya existe, el sistema rechaza el procesamiento.

## Casos de prueba

✅ Pago con nueva Idempotency Key.

✅ Reenvío del mismo pago con la misma Key.

✅ Pago diferente con una Key distinta.

## Casos de borde
- Mismo monto + misma Key → no procesa nuevamente.
- Mismo monto + distinta Key → sí procesa.
- Distinto monto + misma Key → se considera la misma operación y no debe procesarse otra vez.

## Diseño

- Pago: representa la solicitud.
- PagoService: contiene la lógica de idempotencia.
- HashSet: almacena las claves procesadas para evitar duplicados.