// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число 
// кратным второму. Если первое число некратно второму, то программа выводит остаток от деления.

// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int reminder = num1 % num2;
if (reminder == 0)
{
    Console.Write("первое число кратно второму");
}
else
{
    Console.Write("первое число некратно второму, " + "остаток " + reminder);
}