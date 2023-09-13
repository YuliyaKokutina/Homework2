Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
void ShowCube(int N)
{
for (int i = 2; i <=N; i++)
{
    System.Console.WriteLine(i*i*i);
}
}
ShowCube(N);