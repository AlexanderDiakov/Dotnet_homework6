// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите рамер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[size];

void FillInputNumbers(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введи число {i + 1} ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(arrayNumbers[i]);
    }
}

int SumOfPositiveNumbers(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0)
            count += 1;
    }  
    return count;
}

FillInputNumbers(size);
Console.WriteLine($"сумма чисел больше 0 = {SumOfPositiveNumbers(arrayNumbers)} ");