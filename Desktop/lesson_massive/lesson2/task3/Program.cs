﻿Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10,10);
Console.WriteLine(string.Join(" ",array));

for(int i = 0; i < array.Length; i++)
     array[i] *= -1;
Console.WriteLine(string.Join(" ",array));

