/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
System.Console.WriteLine("Введите размер массива");
int count = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение массива");
int max = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение массива");
int min = int.Parse(Console.ReadLine());
int [] Fillarray(int count,int max, int min)
{
int [] array = new int [count];
Random rand = new Random();
for (int i = 0; i < count; i++)
{
    array [i] = rand.Next(min, max+1);
}
return array;
}
void Printarray(int [] array)
{
for (int i = 0; i < count; i++)
{
    System.Console.Write($"\t {array[i]}");
    }}
    int [] array = Fillarray(count, max, min);
    Printarray(array);
