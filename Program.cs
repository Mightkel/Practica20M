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

//Mostrar
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== MOSTRANDO NOTAS ===");
Console.ResetColor();
for (int i = 0; i < 25; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
    Console.ResetColor();
    if (notas[i] < 70)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.ResetColor();
}

//3 primeros lugares

//Mostrar descendente
