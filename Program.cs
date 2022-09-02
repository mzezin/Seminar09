// Написать программу, которая на вход получает массив данных от пользователя
// через запятую и на выходе выдаёт массив состоящий из четных чисел

// пример:
// 1,2,3,4,5,6,7,8 => 2 4 6 8


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine("]");
}

int[] processInput(string input) //на вход получает массив данных от пользователя через запятую и на выходе выдаёт массив
{
    string[] stringArray = input.Split(",");
    int[] result = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (!int.TryParse(stringArray[i], out int number))
            return new int[0] { };
        result[i] = number;
    }
    return result;
}

int[] SelectArray(int[] array)
{
    //магия
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven++;
    }

    int[] result = new int[countEven];
    int resultIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[resultIndex] = array[i];
            resultIndex++;
        }
    }
    return result;
}


int[] array = new int[0];
bool correctInput = false;
while (!correctInput)
{
    string inputString = Console.ReadLine();
    array = processInput(inputString);
    if (array.Length > 0)
        correctInput = true;
    else
        Console.WriteLine("Неправильый ввод");
}

int[] evenArray = SelectArray(array);
PrintArray(evenArray);
