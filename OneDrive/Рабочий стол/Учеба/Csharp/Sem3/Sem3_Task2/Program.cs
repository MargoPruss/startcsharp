﻿// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрицательные 
// элементы на положительные, а положительные на отрицательные.

// Пример

// [1 -5 6]
// => [-1 5 -6]

int[] array = new int [10] {-10, -8, 7, 4, 3, -2, 8, 10, -5, 9};
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    if (i < array.Length - 1)
    {
        Console.Write(array[i] + ", ");
    }
    else
    {
        Console.Write(array[i]);
    }
    
}