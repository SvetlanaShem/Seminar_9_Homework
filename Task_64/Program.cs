Console.Clear();
int n = GetNum("Введите натуральное число: ", "Ошибка ввода!");
string result = PrintDigits(n);
Console.WriteLine(result);

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

string PrintDigits(int a)
{
    if (a == 1)
        return 1.ToString();
    return (a + "," + PrintDigits(a - 1));
}