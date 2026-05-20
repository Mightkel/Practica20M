//Crear una aplicacion que guarde los registros de notas de 25 estudiantes
//Debe presentar un menú
//1. Agregar
//2. Mostrar
//3. Mostrar los 3 primeros lugares
//4. Mostrar las notas en orden descendente
//5. Salir

int [] notas = new int [25];

//Agregar
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine("Ingrese las notas de los 25 estudiantes:");
Console.ResetColor();
for (int i = 0; i < 25; i++)
{
    try
    {
        Console.Write($"Nota #{i+1}: ");
        notas[i] = int.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Valor invalido. Por favor ingrese un numero entero.");
        Console.ResetColor();
        i--;
    }
}
//Mostrar

//3 primeros lugares

//Mostrar descendente
