/* УКРАШАТЕЛЬСТВО КОНСОЛИ */
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
/* Исключение букв и символов */
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
// создание массива на выбор рандомного или ручного
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
// заполнение массива как вручную так и рандома
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
// метод печати массива в консоль
void ShowArray(int[] arr)
{
    foreach (int i in arr) 
    {
        Console.Write(String.Format(" {0,3}", i));
    }
    Console.Write('\n');
}
// перемешивание массива
void Shuffle(int[] arr)
{
    for (int a = arr.Length - 1; a >= 0; a--)
    {
    int b = new Random().Next(a);
    (arr[a], arr[b]) = (arr[b], arr[a]);
    }
    Console.Write("A shuffled arr: ");
    ShowArray(arr);
}
// вывод в консоль количества четных
void CountOfEvens(int[] arr)
{
    int evens = 0; for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) evens++;
    Console.Write("Count of evens:   ");
    Console.WriteLine(evens);
}
// вывод в консоль суммы каждого нечетного
void SumOfOdds(int[] arr)
{
    int odds = 0; for (int i = 0; i < arr.Length; odds += arr[i], i += 2) ;
    Console.Write("Summ of val by odd indices:   ");
    Console.WriteLine(odds);
}
// вывод в консоль max & min
void MaxMin(int[] arr)
{
    // Console.Write($"Max is: {arr.Max()} Min is: {arr.Min()} "); 
    int max = arr[0]; int min = arr[0];
    foreach (int a in arr) if (a > max) max = a; else if (a < min) min = a;
    Console.Write($"Max value is: {max}\nMin value is: {min}\n");
}
// перемножение крайних пар к центру
void MultEdges(int[] arr)
{
    int size = arr.Length - 1;
    bool flag = size % 2 == 0;
    Console.Write("Products of ev: ");
    for (int i = 0; i < size; i++, size--)
    {
        Console.Write(String.Format(" {0,3}", arr[i] * arr[size]));
    }
    if (flag) Console.WriteLine(String.Format(" {0,3}", arr[arr.Length / 2 + 1])); 
    else Console.WriteLine(" ");
}
// инвертирование самого массива
void InvertArray(int[] arr)
{
    int size = arr.Length - 1;
    for (int i = 0; i < size; i++, size--) (arr[i], arr[size]) = (arr[size], arr[i]);
    Console.Write("Inverted array: ");
    ShowArray(arr);
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
// сортировка массива
void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++) if (arr[j] < arr[min]) min = j;
        (arr[i], arr[min]) = (arr[min], arr[i]);
    }
    Console.Write("A sorted array: ");
    ShowArray(arr);
}
// метод нахождения заданного числа в массиве
void FindVallueArray(int[] arr, int value)
{
    string result = "out of the Array";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            result = "in the Array"; break;
        }
    }
    Console.WriteLine($"Value {value} {result}");
}
// метод инверсии значений массива
void InverseNumsArray(int[] arr)
{
    for (int i = 0; i < arr.Length; arr[i] = -arr[i], i++) ;
    Console.Write("Inverted vals in: ");
    ShowArray(arr);
}
// метод подсчета суммы плюсов и минусов
void SumPMArray(int[] arr)
{
    int sumP = 0; int sumM = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumP += arr[i];
        if (arr[i] < 0) sumM += arr[i];
    }
    Console.Write($"Summ of pluses:    {sumP}\nSumm o'minuses:   {sumM}\n");
}
// Метод копирования массива
void CopyArray(int[] array)
{
    int[] copyarr = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        copyarr[index] = array[index];
    }
    Console.Write($"Main array:   ");
    ShowArray(array);
    Console.Write($"Copy of:   ");
    ShowArray(copyarr);
}
void Fibonacci(int len)
{
    int[] arr = new int[len];
    arr[0] = 0; arr[1] = 1;
    for (int i = 2; i < len; i++)
    {
        arr[i] = arr[i - 1]+ arr[i - 2];
    }
    Console.Write("Your fibonacci array: ");
    ShowArray(arr);
}

// основной код и меню
int[] arr = NewArray();
static void Help()
{
    Console.WriteLine(@"\nСhoose digit of action, where:
    
    0 or 'stop' - to 'STOP' or break the program
    
    1 - Invert Numbers in Array
    2 - Sort of Array
    3 - Reverse Array
    4 - Product of Extreme values
    5 - Find exact value in Array
    6 - Write Sum of pluses & sum of minuses
    7 - Show Max&min\n8 - Show Sum of values by odd indicies
    9 - Show count of evens
    10 - to shuffle array
    11 - Show counts of positive numbers
    12 - Copying of array
    13 - make fibonacci row
    'new' - to create a new Array
    Any other input - renew script & show HELP\n");
}
Help();

// вызовы всех методов для будущего калькулятора
while (true)
{
    string input = Console.ReadLine()!;
    if (input == "0" || input == "stop" || input == "break") break;
    else if (input == "new")
    {
        arr = NewArray();
    }
    else if (input == "1") InverseNumsArray(arr);
    else if (input == "2") SortArray(arr);
    else if (input == "3") InvertArray(arr);
    else if (input == "4") MultEdges(arr);
    else if (input == "5")
    {
        int value = GetNum("Input value to search in: ");
        FindVallueArray(arr, value);
    }
    else if (input == "6") SumPMArray(arr);
    else if (input == "7") MaxMin(arr);
    else if (input == "8") SumOfOdds(arr);
    else if (input == "9") CountOfEvens(arr);
    else if (input == "10") Shuffle(arr);
    else if (input == "11") CheckPoses(arr);
    else if (input == "12") CopyArray(arr);
    else if (input == "13")
    {
        int value = GetNum("Input value to fibonacci row: ");
        Fibonacci(value);
    }
    else Help(); continue;
}