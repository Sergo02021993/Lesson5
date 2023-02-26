// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

// _________________________________________________________________
int lenArray = InputInt("Введите длинну массива: ");
int minValue = InputInt("Введите минимальное значение массива: ");
int maxValue = InputInt("Введите максимальное значение массива: ");
// _________________________________________________________________

int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// _________________________________________________________________

int[] array = new int[lenArray];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue,maxValue + 1);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

// _________________________________________________________________

int SumElements(int[] array)
{
    int Sum = 0;
    for(int x = 0; x < array.Length; x+=2)
    {
        Sum = Sum + array[x];
    }
    return Sum;
}
System.Console.WriteLine($"Cумма элементов стоящих на нечётных позициях равна: {SumElements(array)}");