// Задача 2: Задайте строку, содержащую латинские 
// буквы в обоих регистрах. Сформируйте строку, в 
// которой все заглавные  буквы  заменены  на строчные.

// “aBcD1ef!-” => “abcd1ef!-”

string str = "aBcD1ef!-";

string StringToLower(string str)
{
    string result = string.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToString() == str[i].ToString().ToLower())
        {
            result += str[i];
        }
        else
        {
            result += str[i].ToString().ToLower();
        }
    }

    return result;
}
string result = StringToLower(str);
Console.WriteLine(result);

