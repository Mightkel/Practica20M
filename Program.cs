//Crear una aplicacion que guarde los registros de notas de 25 estudiantes
//Debe presentar un menú
//1. Agregar
//2. Mostrar
//3. Mostrar los 3 primeros lugares
//4. Mostrar las notas en orden descendente
//5. Salir

int [] notas = new int [25];

//Agregar

//Mostrar

//3 primeros lugares
Array.Sort(notas[]);
Array.Reverse(notas[]);

Console.WriteLine("========= NOTAS TOP 3 ========")
for(int i = 0; i < 3; i++){
    Console.WriteLine($"{i+1}. {notas[i]}");
}

//Mostrar descendente
