Console.Clear();
int m = GetNum("Введите натуральное число: ", "Ошибка ввода!");
int n = GetNum("Введите натуральное число: ", "Ошибка ввода!");
int result = AkkermanFunction(m, n);
Console.WriteLine($"Результат вычисления функции Аккермана равен {result}");

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
int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
    else return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
}