/*Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] animals = {"tiger", "cow", "owl", "horse", "sheep", "duck", "goose", "hen", "cat", "dog"};

string[] MainWork (string[] inputArray)
{
    int len = 0;
    int count = inputArray.Length;

    for (int k = 0; k < count; k++)
    {
        if (inputArray[k].Length < 4) len ++;
    }

    string[] outputArray = new string [len];
    int i = 0; int index = 0;
    while (i < count)
    {
        if (inputArray[i].Length < 4)
        {
            outputArray[index] = inputArray[i];
            index ++;
        }
        i++;
    }
    return outputArray;
}

string PrintArray (string[] arr)
{
    string res = String.Empty;
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        res += $"{arr[i]} ";
    }
    return res;
}

Console.WriteLine($"initial array: {PrintArray(animals)}");
string[] finalArr = MainWork(animals);
Console.WriteLine($"changed array: {PrintArray(finalArr)}");
