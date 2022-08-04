// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

/// <summary>
/// Вывод элеменов массива в console
/// </summary>
/// <param name="array">Исходный массив</param>
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[\"" + string.Join("\", \"", array) + "\"]");
    }
}

/// <summary>
/// Из исходного массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символа
/// </summary>
/// <param name="array">Исходный массив строк</param>
/// <returns>Массив из строк, длина которых меньше либо равна 3 символа, или пустой массив</returns>
string[] GetModifyArray(string[] array)
{
    const int maxNumberCharsInWord = 3;
    int index_j = 0;
    for (int index_i = 0; index_i < array.Length; index_i++)
    {
        if (array[index_i].Length <= maxNumberCharsInWord)
        {
            index_j++;
        }
    }

    string[] result = new string[index_j];
    index_j = 0;
    for (int index_i = 0; index_i < array.Length; index_i++)
    {
        if (array[index_i].Length <= maxNumberCharsInWord)
        {
            result[index_j] = array[index_i];
            index_j++;
        }
    }
    return result;
}

string[] array = new string[] { "hello", "2", "world", ":-)" };
PrintArray(array);
Console.Write(" -> ");
PrintArray(GetModifyArray(array));