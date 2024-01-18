Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int[] new_array = new int [n / 2]; 

for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,10);
Console.WriteLine(string.Join(" ",array));

for(int i = 0; i<array.Length/2;i++)
    new_array[i] = array[i] * array[array.Length - 1 -i];
Console.WriteLine(string.Join(" ",new_array));
