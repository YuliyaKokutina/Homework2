/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
System.Console.WriteLine("Введите число А : ");
int numA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B : ");
int numB = int.Parse(Console.ReadLine());
int result = 1;
int Cub(int numA, int numB)
{
for (int i = 1; i <= numB; i++)
{
    result = result *numA;
}
return result;}
int multy = Cub(numA, numB);
System.Console.WriteLine(multy);