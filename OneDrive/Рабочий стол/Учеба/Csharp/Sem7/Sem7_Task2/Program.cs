// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9


int SumOfDigitNum(int num)
{
    if(num == 0) return 0;
    return num%10 + SumOfDigitNum(num / 10);
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigitNum(number));