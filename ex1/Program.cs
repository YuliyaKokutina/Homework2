System.Console.WriteLine("Введите размер массива");
int count = int.Parse(Console.ReadLine());
int [] array = new int [count];
int i = 0;


for (i = 0; i < array.Length ; i++)
{System.Console.WriteLine($"Введите {i} элемент массива");
    array [i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i]);
}