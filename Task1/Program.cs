// Напишите программу, 
// которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите число: ");

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);

void Palindrome(int n)
{
    int i=0;
    string num = n.ToString();
    int size = num.Length -1;
    string flag = "yes";

    while (i<size /2)
    {
        if (num[i] != num[size - i])
        {
            flag = "no";
            break;
        }
        i += 1;
    }
    Console.WriteLine($"{n} -> {flag}");
}
Palindrome(n_1);
