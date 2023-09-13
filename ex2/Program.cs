int [] pointA = new int [3];
int [] pointB = new int [3];
int i = 0;
int j = 0;
for (i = 0; i < pointA.Length ; i++)
{System.Console.WriteLine($"Введите {i} координаты точки A");
    pointA [i] = int.Parse(Console.ReadLine());}
    for (j = 0; j < pointB.Length ; j++)
{System.Console.WriteLine($"Введите {j} координаты точки B");
    pointB [j] = int.Parse(Console.ReadLine());}

double Length(int[] pointA, int[] pointB)
{ 
int x1 = pointA [0];
int y1 = pointB [0];
int x2 = pointA [1];
int y2 = pointB [1];
int x3 = pointA [2];
int y3 = pointB [2];
int x = y1-x1;
int y = y2-x2;
int z = y3-x3;
double length = Math.Round(Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y,2) + Math.Pow(z,2)),2);
System.Console.WriteLine(length);
return length;
};
Length(pointA, pointB);