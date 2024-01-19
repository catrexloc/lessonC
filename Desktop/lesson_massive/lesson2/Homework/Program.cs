// int result = 0;
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// int minRange = 10;
// int maxRange = 90;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > minRange & array[i] < maxRange)
//     {result = result + 1;}
// }

// Console.WriteLine(result);

// int result = 0;
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// int minRange = 10;
// int maxRange = 90;
// for(int i = 0; i < array.Length; i++)

// {
//     if((array[i] > minRange) & (array[i] < maxRange))
//     {result = result + 1;}
// }

// Console.WriteLine(result);

// int[] numbers = new int[10] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// int result =0;
// for (int i =0; i<numbers.Length; i++)
// {
//     if(numbers[i] >= 10 && numbers[i] <= 90)
//     {
//         result++;
//     }
// }
// Console.WriteLine(result);

// int result =0;
// for (int i =0; i<numbers.Length; i++)
// {
//     if(numbers[i] >= minRange && numbers[i] <= maxRange)
//     {
//         result++;
//     }
// }
// return (result);
    
//     {
        
//           //Введите сюда свое решение
//       Console.WriteLine(CountItemsRange(array, 10, 90));
//     }

// int[] numbers = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
// int result =0;
// for (int i =0; i<numbers.Length; i++)
// {
//     if(numbers[i]%2==0)
//     {
//         result++;
//     }
// }

// return (result);

//  Console.WriteLine(result);

double[] numbers = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double min = numbers[0];
double max = numbers[0];
int i = 0;

while(i < numbers.Length)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    i = i + 1;
}

while(i < numbers.Length)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    i = i + 1;
}

double result = max - min;
Console.Write(result);

class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива

    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    // Нахождение максимума массива
    public static double FindMax(double[] numbers)

     {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }



    public static void PrintResult(double[] array)
    {
 double result = FindMax(array) - FindMin(array);
        Console.WriteLine(result);
    }
}





