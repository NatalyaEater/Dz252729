// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число А ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число В ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
int exp2=Exponentiation( numberA ,numberB);//применяем функцию к нашим числам

Console.WriteLine(exp2);

int Exponentiation(int A ,int B)
{
int exp =1;
int num=0;
while (num<B)
{
exp=exp*A;
num=num+1;
}
return exp;
}