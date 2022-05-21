// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write("Введите число: ");

// string s_n_1 = Console.ReadLine();
// int n_1 = int.Parse(s_n_1);

// void Squares(int num)
// {
//     int i = 1;
//     Console.Write($"{num} -> ");

//     while (num >= i)
//     {
//         Console.Write($"{(Math.Pow(i, 3))} ");
//         i++;
//     }
//     Console.WriteLine( );
// }
// Squares(n_1);


Console.Clear();
Console.Write("Введите число: ");

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);

void Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;
    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]} ");
        index += 1;
    }
    Console.WriteLine();
}

Squares(n_1);
