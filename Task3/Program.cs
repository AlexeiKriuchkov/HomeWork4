// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Promt(string message)

{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
}
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.WriteLine($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int length = Promt("Длина массива: ");
int min = Promt("Начальное значение, для диапозона случайного числа: ");
int max = Promt("Конечное значение, для диапозона случайного числа: ");
int [] array = GenerateArray(length, min, max);
PrintArray(array);