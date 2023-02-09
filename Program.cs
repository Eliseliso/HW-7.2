// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int num2 = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
GenerateMatrix(numbers);
if (num1 > numbers.GetLength(0) || num2 > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Значение числа с этими данными => " + numbers[num1-1, num2-1]);
}
ShowMatrix(numbers);
void GenerateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}
void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}