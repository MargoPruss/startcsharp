// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд 
// числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите 3х-значное число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = num % 10;
    num /= 10;
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}