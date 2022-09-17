/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте исполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 Примеры:
 - ["hello", "2", "world", ":-)"]->["2", ":-)"]
- ["1234", "1567", "-2", "computer science"]->["-2"]
- ["Russia", "Denmark", "Kazan"]->[]
*/
Console.Clear();

string[] arrayString = { "hello", "2", "world", ":-)" };
int lessLength = 3;

Console.WriteLine("Исходный массив строк:");
printArray(arrayString);
Console.WriteLine($"Кол-во строк состоящих из {lessLength} или менее символов = {CountWordsLength(arrayString, lessLength)} ");
Console.WriteLine($"Строки состоящие из {lessLength} и менее символов:");
printArray(FillArrayWords(arrayString, lessLength));


int CountWordsLength(string[] arrStr, int L)
{
    int count = 0;
    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= L) count++;
    }
    return count;
}

string[] FillArrayWords(string[] arrStr, int L)
{
    int j = 0;
    string[] resultArray = new string[CountWordsLength(arrStr, L)];

    for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= L)
        {
            resultArray[j] = arrStr[i];
            j++;
        }
    }

    return resultArray;
}

void printArray(string[] arrStr)
{
    for (int i = 0; i < arrStr.Length; i++)
        Console.Write(arrStr[i] + " ");
    Console.WriteLine();
}

