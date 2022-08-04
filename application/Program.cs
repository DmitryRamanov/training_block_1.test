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
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j++;
        }
    }

    string[] result = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

string[] array = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(array);
Console.Write(" -> ");
PrintArray(GetModifyArray(array));