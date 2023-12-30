// Console.Clear();
// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 100;
// int n3 = n % 10;

// Console.WriteLine(n1*10 + n3);


// Console.Clear();
// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = n % 100 / 10;
// int n3 = n % 10;
// Console.WriteLine(Math.Pow(n2, n3));

// Console.Clear();
// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// if ( n % a == 0)
// Console.WriteLine("yes");
// else 
// Console.WriteLine("no, " + n % a);

Console.Clear();
Console.Write("Введите число ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (n < 100)
Console.Write("число не трехзначное");
else
{
while(n > 999)
    n/=10;
Console.WriteLine(n % 10);
}