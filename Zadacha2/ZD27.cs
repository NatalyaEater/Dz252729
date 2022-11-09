// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.WriteLine("Введите число  ");
int number = int.Parse(Console.ReadLine() ?? "0");

int sum2=SumNumber(number);
Console.WriteLine(sum2);

//функция
int SumNumber(int randomnum)
{
 int i = 0;
 int sum=0;
 int ost=0;
 while (randomnum >i)
    {
 ost=randomnum%10;
    sum=sum+ost;
    randomnum=randomnum/10;
    }
 return sum;
}
