// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void CheckTriangle(int A, int B, int C)
{
    if ((A + B) < C)
    {
        if (B+C < A)
        {
            if (C+A < B)
            {
                Console.WriteLine();
            }
        }
    }
  string result = (((A + B) < C) && ((A + C) < B) && ((B + C) < A)) ? " Да " : " Нет";
  Console.WriteLine(result);
}
int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}
//зададим числа
int num = GetNum("Введите длину сторона АВ: ");
int num1 = GetNum("Введите длину сторона АС: ");
int num2 = GetNum("Введите длину сторона ВС: ");
CheckTriangle(num, num1, num2);