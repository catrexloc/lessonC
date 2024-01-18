Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];

for(int i = 0; i < array.Length; i++)
{
    array[i] = n%10;
    n /= 10;
}
  Console.WriteLine(string.Join(" ",array));
