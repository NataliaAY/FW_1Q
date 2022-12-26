using System;
using static System.Console;

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int x)
{
    string[] output = new string[CountLessThan(input, x)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= x)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] AskArray()
{
    Write("Введите любые символы через пробел: ");
    return ReadLine().Split(" ");
}
