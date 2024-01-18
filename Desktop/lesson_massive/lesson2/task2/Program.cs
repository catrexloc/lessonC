Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int k = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,10);

// for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");

Console.Write(string.Join(" ",array));

bool flag = true;
for(int i = 0; i < array.Length; i++)
 {
    if (array[i] == k)
    {Console.WriteLine("yes");
     // else
     //    Console.WriteLine("no"); 
    flag = false;
    break;}
 }
 if (flag == true)
    Console.WriteLine("no");
