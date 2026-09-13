using System;


Console.Write("Nombre completo: ");
string nombre = Console.ReadLine();

Console.Write("Matrícula: ");
string matricula = Console.ReadLine();

Console.Write("Plantel: ");
string plantel = Console.ReadLine();

Console.Write("Semestre: ");
string semestre = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Introduce las 5 calificaciones:");

double[] calificaciones = new double[5];
double suma = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Calificación {i + 1}: ");
    calificaciones[i] = Convert.ToDouble(Console.ReadLine());
    suma += calificaciones[i];
}

double promedio = suma / 5;

Console.WriteLine();
Console.WriteLine("--- INFORMACIÓN DEL ALUMNO ---");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Matrícula: {matricula}");
Console.WriteLine($"Plantel: {plantel}");
Console.WriteLine($"Semestre: {semestre}");

Console.WriteLine($"Promedio: {promedio:F2}");
