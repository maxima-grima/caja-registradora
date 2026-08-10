const string CommerceName = "Maxikiosco";
Console.WriteLine ($"Bienvenido al {CommerceName}");
Console.Write ("Nombre del cajero: ");
string cashiername = Console.ReadLine();
Console.WriteLine($"Bienvenido, {cashiername}. Caja Abierta.");
Console.Write("Ingrese el nombre del producto: ");
string productName = Console.ReadLine();
Console.Write("Ingrese el precio del producto: ");
decimal productPrice = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Producto: {productName}, Precio: {productPrice}");
Console.Write("¿Qué desea hacer ?" +
    "1 - Cargar un producto" +
    "2 - Cerrar la venta");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        Console.Write("Ingrese el nombre del producto: ");
        string productName2 = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        decimal productPrice2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"Producto: {productName2}, Precio: {productPrice2}");
        break;
    case 2:
        Console.WriteLine("Venta cerrada.");
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
};