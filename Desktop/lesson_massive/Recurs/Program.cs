/*• Вычислить факториал от натурального
числа N
Лекция 5. Рекурсия в программировании
Этапы создания рекурсии
1. Рекурсивный вызов
2. Условие остановки рекурсии
N! = N*(N-1)!
3! = 3 * 2 */

int Fact(int n)
{
    if (n == 1|| n == 0  )
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
int i = n;
    Console.WriteLine(n);
    n = n * Fact(n - 1);
    Console.WriteLine($"Возврат: n = {i}; fact = {n}");
    return n;
}
Console.Write(Fact(5));