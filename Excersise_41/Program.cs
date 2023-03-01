// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "  ");
}

int[] StringToArray(string numbers)
{
    string[] str = numbers.Split(" ", StringSplitOptions.None);
    int[] result = new int[str.Length];

    for (int i = 0; i<str.Length; i++)
    {
        result[i] = int.Parse(str[i]);
    }

    return result;
}

Console.Write("Задайте элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] array = StringToArray(elements);
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    count = array[i]>0 ? count+1 : count;
}

Console.WriteLine();
Console.WriteLine($"Count of positive numbers is {count}");