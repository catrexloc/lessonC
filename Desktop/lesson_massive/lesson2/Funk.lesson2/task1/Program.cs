// int func (int a , int b)
// {
//     if(a > b)
//       return a;
//     else
//       return b;
// }
// Console.Clear();
// int res = func(5,10);
// Console.Write(res);

// void func(int a, int b)
// {
//     if (a > b)
//         Console.WriteLine(a);
//     else
//         Console.WriteLine(b);
// }
// func(50, 10);
// func(8, 2);
// func(3, 6);

// void InputArray(int[]array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] =new Random().Next(20,25);
// }

// void ReleaseArray(int[] array)
// {
//     int count = 0;
// for(int i = 0; i < array.Length; i++)

//     if(array[i]%7==0 && array[i]%10==1)
//         count++;
// Console.Write(count);
// }

// Console.Clear();
// Console.WriteLine("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine(string.Join(", ",array));
// ReleaseArray(array);

// void InputArray(int[]array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] =new Random().Next(20,25);
// }

// bool ChekProst(int x)
// {
//     for(int i = 2; i < x; i++)
//        if(x%i == 0)
//        return false;
//     return true;
// }

// void ReleaseArray(int[] array)
// {
//     int count = 0;
// for(int i = 0; i < array.Length; i++)

//     if(ChekProst(array[i]))
//         count++;
// Console.Write(count);
// }

// Console.Clear();
// Console.WriteLine("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine(string.Join(", ",array));
// ReleaseArray(array);


void InputArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] =new Random().Next(0,9);
}

void ReleaseArray(int[] array)
{
    int res = 0;
    for(int i = 0; i < array.Length; i++)
     res = res * 10 + array[i];

     Console.WriteLine(res);
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray(array);
Console.WriteLine(string.Join(", ",array));
ReleaseArray(array);
