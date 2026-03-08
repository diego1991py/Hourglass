

using Task.Backend;

Console.Write("Ingrese orden de la matriz: ");
int n = int.Parse(Console.ReadLine());

Matrix matrix = new Matrix(n);

matrix.FillMatrix();

Console.WriteLine("MATRIZ COMPLETA");
matrix.ShowMatrix();

Console.WriteLine();
Console.WriteLine("RELOJ DE ARENA");

matrix.ShowHourGlass();