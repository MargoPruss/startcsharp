// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l 
// “World” => W r l d 
// “Hello world!” => H l l w r l d

void PrintConsonants (string str)
{
    if(str.Length == 0) return;
    string chars = "aeiouy";
    if(char.IsAsciiLetter(str[0]) && !chars.Contains(str[0]))
        Console.Write($"{str[0]} ");
    PrintConsonants(str.Substring(1));
}


Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();

PrintConsonants(str);