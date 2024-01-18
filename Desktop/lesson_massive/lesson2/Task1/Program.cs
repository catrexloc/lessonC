Console.Clear();
Console.WriteLine("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,10);

// for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");

Console.Write(string.Join(" ",array));