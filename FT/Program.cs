// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

bool StringCanBeParsedToInt(string text)
{
    int length = text.Length;
    if (length == 0) 
        return false;
    for (int i = 0; i < length; i++)
        if (text[i] != '0' && text[i] != '1' && text[i] != '2' &&
            text[i] != '3' && text[i] != '4' && text[i] != '5' &&
            text[i] != '6' && text[i] != '7' && text[i] != '8' &&
            text[i] != '9')
            return false;
    return true;
}

string[] InputStringArray(int length)
{
    string[] tempArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива строк: ");
        tempArray[i] = Console.ReadLine() ?? "";
    }
    return tempArray;
}