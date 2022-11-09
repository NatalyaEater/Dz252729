// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.(в примере показаны два разных массива, создаем именно для 8 элементов)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.WriteLine("Задайте длинну массива");
int  numberLength= int.Parse(Console.ReadLine() ?? "0");
int []array=new int[numberLength];
arrayRandom(array);

//функция
int[] arrayRandom (int []array)
{
for (int i=0; i<array.Length;i++)
{
    array[i]=new Random().Next(0,9);
Console.Write(array[i]+" ");
}
return array;
}
