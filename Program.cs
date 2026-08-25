const string CommerceName = "Maxikiosco";
const decimal DescuentoAltoPorc = 0.10m;   
const decimal DescuentoMedioPorc = 0.05m;  
const decimal MinimoDescuentoAlto = 50000m;
const decimal MinimoDescuentoMedio = 20000m;
const decimal DescuentoEfectivoPorc = 0.10m;
const decimal RecargoCreditoPorc = 0.15m;
Console.WriteLine ($"Bienvenido al {CommerceName}");
Console.Write ("Nombre del cajero: ");
string cashiername = Console.ReadLine();
Console.WriteLine($"Bienvenido, {cashiername}. Caja Abierta.");
decimal total = 0;
int productCount = 0;
bool saleOpen = true;
while (saleOpen)
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            string productName2 = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            decimal productPrice2 = decimal.Parse(Console.ReadLine());
            total += productPrice2;
            productCount++;
            Console.WriteLine($"Producto: {productName2}, Precio: {productPrice2}");
            break;
        case 2:
            saleOpen = false;

            decimal subtotal = total;
            decimal descuentoPorMonto;
            if (subtotal > MinimoDescuentoAlto)
            {
                descuentoPorMonto = subtotal * DescuentoAltoPorc;
            }
            else if (subtotal > MinimoDescuentoMedio)
            {
                descuentoPorMonto = subtotal * DescuentoMedioPorc;
            }
            else
            {
                descuentoPorMonto = 0;
            }

            decimal totalConDescuento = subtotal - descuentoPorMonto;

            Console.WriteLine($"Venta cerrada. Total de productos: {productCount}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Descuento: {descuentoPorMonto}");
            Console.WriteLine($"Total con descuento: {totalConDescuento}");
            decimal descuentoPago = 0;
            decimal recargoPago = 0;
            bool pagoValido = false;

            while (!pagoValido)
            {
                Console.WriteLine();
                Console.WriteLine("Medio de pago:");
                Console.WriteLine("1 - Efectivo");
                Console.WriteLine("2 - Débito");
                Console.WriteLine("3 - Crédito");
                Console.Write("Opción: ");
                int metodoPago = int.Parse(Console.ReadLine());

                switch (metodoPago)
                {
                    case 1:
                        descuentoPago = totalConDescuento * DescuentoEfectivoPorc;
                        pagoValido = true;
                        break;
                    case 2:
                        pagoValido = true;
                        break;
                    case 3:
                        recargoPago = totalConDescuento * RecargoCreditoPorc;
                        pagoValido = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
            decimal totalFinal = totalConDescuento - descuentoPago + recargoPago;
            Console.WriteLine($"Total final a pagar: {totalFinal}");
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;

    }

}