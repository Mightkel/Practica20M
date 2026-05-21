//Crear una aplicacion que guarde los registros de notas de 25 estudiantes
//Debe presentar un menú
//1. Agregar
//2. Mostrar
//3. Mostrar los 3 primeros lugares
//4. Mostrar las notas en orden descendente
//5. Salir

using System.Reflection.Metadata;

int[] notas = new int[25];

//Agregar

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Ingrese las notas de los 25 estudiantes:");
Console.ResetColor();
for (int i = 0; i < 25; i++)
{
    try
    {
        Console.Write($"Nota #{i + 1}: ");
        notas[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor ingrese un numero entero.");
        Console.ResetColor();
        i--;
    }
}
//Mostrar
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== NOTAS AGREGADAS ===");
Console.ResetColor();
for (int i = 0; i < 25; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"Nota {i + 1}: ");
    if (notas[i] < 70) Console.ForegroundColor = ConsoleColor.Red;
    else Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(notas[i]);
    Console.ResetColor();

}

//3 primeros lugares


Console.WriteLine("========= NOTAS TOP 3 ========");
for (int i = 0; i < 3; i++)
{
    Array.Sort(notas);
    Array.Reverse(notas);
    Console.WriteLine($"{i + 1}. {notas[i]}");
}
//Mostrar descendente

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=== NOTAS DESCENDENTES ===");
Console.ResetColor();
for (int i = 0; i < 25; i++)
{
    Array.Sort(notas);
    Array.Reverse(notas);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
    Console.ResetColor();
}