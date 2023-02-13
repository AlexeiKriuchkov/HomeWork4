// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string massage)
{
    System.Console.WriteLine(massage);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool validateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Promt("Введите основание: ");
int exponent = Promt("Введите показатель: ");
if (validateExponent(exponent))
{
    System.Console.WriteLine("Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}

