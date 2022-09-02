// Написать программу, которая на вход получает массив данных от пользователя
// через запятую и на выходе выдаёт массив состоящий из четных чисел

// пример:
// 1,2,3,4,5,6,7,8 => 2 4 6 8


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i] + "]");
        else Console.Write(array[i] + ", ");
    }
}

int[] processInput() //на вход получает массив данных от пользователя через запятую и на выходе выдаёт массив
{
    string input = Console.ReadLine();
    string[] stringArray = input.Split(",");
    int[] result = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (!int.TryParse(stringArray[i], out int number))
            throw new Exception("Ошибка ввода");
        result[i] = number;
    }
    return result;
}

