// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int lenArray = InputInt("Введите длинну массива: ");
int minValue = InputInt("Введите минимальное значение массива: ");
int maxValue = InputInt("Введите максимальное значение массива: ");

// Функция ввода данных для массива:
int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода массива с условиями:
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(minValue,maxValue + 1);
    Console.Write(randomArray[i] + " ");
}
System.Console.WriteLine();

// Показывает количество четных чисел
int SearchPositivDigits(int[] randomArray)         // метод поиска двухзначных чисел 
{
    int countDigits = 0;                           // счетчик
    for (int i = 0; i < randomArray.Length; i++)   // цикл перебора индекса
    {
        if (randomArray[i] %2 == 0) countDigits++; // если условие выполняется то увеличиваем счетчик
    }
    return countDigits;                            // возвращаем значение
}
System.Console.WriteLine($"Количество положительных чисел в данном массиве = {SearchPositivDigits(randomArray)}");
