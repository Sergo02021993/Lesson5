// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

// ____________________________________________

int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int length = InputInt ("Введите длину массива: ");
int minValue = InputInt ("Введите минимальное значение: ");
int maxValue = InputInt ("Введите максимальное значение: ");

// ____________________________________________
int[] array = new int[length];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
    System.Console.Write(array[i] + " ");
}
Console.WriteLine();

// ____________________________________________

int searchMax = array[0]; int searchMin = array[0];
for(int i = 1; i < array.Length; i++)
{
    if (array[i] >= searchMax ) searchMax = array[i];    
    if (array[i] <= searchMin ) searchMin = array[i];  
}
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {searchMax - searchMin}");
