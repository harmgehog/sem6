// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;

int GetNum(string text)
{
    do
    {
        try
        {
            Console.WriteLine(text);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong input(need only numbers)!");
        }
    }
    while (true);
}
int[] NewArray()
{
    int rand = GetNum(" Input 1 for Random fill or 2 for custom: ");
    int size = GetNum(" Input size of array: ");
    int min = 0; int max = 0;
    if (rand == 1)
    {
        min = GetNum("Input min edge of array: ");
        max = GetNum("Input max edge of array: ");
    }
    int[] arr = FillArray(size, min, max, rand);
    return arr;
}
int[] FillArray(int size, int min, int max, int rand)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = min == max ? GetNum($"Input {i + 1} value: ") : new Random().Next(min, max + 1);
    }
    Console.Write("Your new array: ");
    ShowArray(arr);
    return arr;
}
void ShowArray(int[] arr)
{
    foreach (int i in arr) 
    {
        Console.Write(String.Format(" {0,3}", i));
    }
    Console.Write('\n');
}
// считаем количество чисел больше 0
void CheckPoses(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > 0)
        {
            count++;
        } 
    }
    Console.WriteLine($"Positive nums in the arr: {count}");
}

// Вызываем создание массива и меню с проверкой на ввод
int[] arr = NewArray();

// вызываем счетчик положительных чисел
CheckPoses(arr);