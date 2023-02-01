// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8
void Fibonacci(int number)
{
    int a = 0; Console.Write($"{a}");
    int b = 1;
    for (int i = 0; i < number; i++)
    {
        (a, b) = (b, a + b);
        Console.Write(string.Format($", {a}"));
    }
}
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int num = GetNum(" Введите число : ");
Fibonacci(num-1);
