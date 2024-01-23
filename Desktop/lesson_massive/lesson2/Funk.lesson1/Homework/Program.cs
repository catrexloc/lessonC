void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void GetSumOfElements(int[] array)
{
int sum = 0;
for(int i = 0; i< array.Length; i++)
    {
        sum += array[i];
    }
    Console.Write(sum);
}

void GetProductOfElements(int[] array)
{
    int product = 1;
for(int i = 0; i< array.Length; i++)
    {
        product = product * array[i];
    }
    Console.Write(product);
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
Console.WriteLine(string.Join(", ",array));

GetSumOfElements(array);

GetProductOfElements(array);





