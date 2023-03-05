// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов в одномерном массиве:");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayUser = CreateArray (number);
EnterNumber (arrayUser);
int numberPositive = PositiveNumber(arrayUser);
Console.WriteLine($"В вашем массиве количество чисел больше нуля: {numberPositive}");

// методы
int[] CreateArray (int arraySize)
{
    int[] array = new int[arraySize];  
    for (int i = 0; i < arraySize; i++)
    {
    Console.WriteLine($"Введите значение {i+1}-го элемента в одномерном массиве:");
    array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void EnterNumber  (int[] array)
{
    Console.Write("Получился следующий массив -> [");
    for (int i = 0; i < array.Length; i++)
    {
    if (i < array.Length-1) Console.Write($"{array[i]}, ");
    if (i == array.Length-1) Console.WriteLine($"{array[i]}]");
    }
}

int PositiveNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;
    }
    return count;
}