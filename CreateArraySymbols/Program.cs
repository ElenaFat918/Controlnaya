// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исклбчительно массивами.

// Примеры
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "-2", "Kazan"] -> []

Console.Clear();
Console.WriteLine("Программа, создающая из массива строк массив из строк, длина которых меньше либо равна заданному количеству символов");
Console.WriteLine("Введите количество элементов в массиве: ");

int size = int.Parse(Console.ReadLine()!);
var firstArr = InputArray(size);

Console.WriteLine("Введите максимальное количество символов в элементе массива: ");
int lengthSymbols = int.Parse(Console.ReadLine()!);

var secondArr = CreateArraySymbols(firstArr, lengthSymbols);
PrintArray(secondArr);

string[] InputArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] CreateArraySymbols(string[] array, int countSymbols)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countSymbols)
            length++;
    }
    var secondaryArray = new string[length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countSymbols)
        {
            secondaryArray[index] = array[i];
            index++;
        }
    }
    return secondaryArray;
}

void PrintArray(string[] array)
{
    Console.Write("Получился массив:\n[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}