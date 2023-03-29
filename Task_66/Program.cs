Console.Clear();
int m = GetNum("Введите натуральное число: ", "Ошибка ввода!");
int n = GetNum("Введите натуральное число: ", "Ошибка ввода!");
int result = GetSum(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {result}");

int GetNum(string message, string error)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine(error);
    }
}
int GetSum(int a, int b)
{
    if (a == b)
        return b;
    return (a + GetSum(a + 1, b));
}