using System;

const string CommerceName = "Maxikiosco";
Console.WriteLine ($"Bienvenido al {CommerceName}");
Console.Write ("Nombre del cajero: ");
string cashiername = Console.ReadLine();
Console.WriteLine($"Bienvenido, {cashiername}. Caja Abierta.");
decimal total = 0;
int productCount = 0;
bool saleOpen = true;
while (saleOpen)
{
    Console.WriteLine();
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar producto");
    Console.WriteLine("2 - Cerrar venta");
    Console.Write("Opción: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            string productName = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            total += productPrice;
            productCount++;
            Console.WriteLine($"Producto: {productName}, Precio: {productPrice}");
            Console.WriteLine($"Total acumulado: {total}");
            break;

        case 2:
            saleOpen = false;
            Console.WriteLine($"Venta cerrada. Total de productos: {productCount}, Total a pagar: {total}");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}