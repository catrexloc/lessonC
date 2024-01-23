// Линейный алгоритм
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 0;
// // int n = ConvertToInt32(Console.ReadLine())
// for(int i = 1; i <= n; i++)
//     result += i;
// Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {n} равна {(1 + n) / 2.0 * n}");