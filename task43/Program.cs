// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/* Console beautification */
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
/* format exception handling */
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
// the intersection point method
void CrossLines(double b1, double k1, double b2, double k2)
{
    try
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = (k2 * b1 - k1 * b2) / (k2 - k1);
            Console.WriteLine($"The coordinates of the intersection point are: {x}; {y}.");
        }
        catch (DivideByZeroException) {
            Console.WriteLine("These lines don't intersect.");
        }
}
// get some variables from console
int b1 = GetNum("Input b1: ");
int k1 = GetNum("Input k1: ");
int b2 = GetNum("Input b2: ");
int k2 = GetNum("Input k2: ");
// call the intersection point method
CrossLines(b1, k1, b2, k2);