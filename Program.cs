const string CommerceName = "Maxikiosco";
const decimal DescuentoAltoPorc = 0.10m;   
const decimal DescuentoMedioPorc = 0.05m;  
const decimal MinimoDescuentoAlto = 50000m;
const decimal MinimoDescuentoMedio = 20000m;
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
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
    
}