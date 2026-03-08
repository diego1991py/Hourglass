

using Task.Backend;

Console.Write("Enter array order: ");
int n = int.Parse(Console.ReadLine());

Matrix matrix = new Matrix(n);

matrix.FillMatrix();

Console.WriteLine("COMPLETE MATRIX");
matrix.ShowMatrix();

Console.WriteLine();
Console.WriteLine("HOURGLASS");

matrix.ShowHourGlass();