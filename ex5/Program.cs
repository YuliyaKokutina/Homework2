/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int sum =0;
int Sum(int num)
{
while (num>0)
{
    int num2 = num%10;
    num /=10;
    sum = sum + num2;

}
return sum;}
sum = Sum(num);
System.Console.WriteLine(sum);
