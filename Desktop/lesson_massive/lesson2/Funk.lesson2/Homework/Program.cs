
// while (true)
// {
//     Console.Write("Введите число или 'q' для выхода: ");
//     string input = Console.ReadLine();
//     if (input == "q")
//     {
//         break;
//     }
//     int number;
//     if (int.TryParse(input, out number))
//     {
//         int sum = 0;
//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//         if (sum % 2 == 0)
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
//     }
// }



//static void Main(){
// int[] numbers = new int[10];
// Random random = new Random();
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = random.Next(100, 1000);
//     Console.Write(numbers[i] + " ");
//     if (numbers[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество четных чисел в массиве: {count}");
//}
// Main();




// static void Main()
// {
//     int[] numbers = { 1, 3, 5, 6, 7, 8 };
//     int temp;
//     Console.Write("Нач массив: ");
//     foreach (int number in numbers)
//     {
//         Console.Write(number + " ");
//     }
//     for (int i = 0; i < numbers.Length / 2; i++)
//     {
//         temp = numbers[i];
//         numbers[i] = numbers[numbers.Length - 1 - i];
//         numbers[numbers.Length - 1 - i] = temp;
//     }
//     Console.Write("Rev. массив: ");
//     foreach (int number in numbers)
//     {
//         Console.Write(number + " ");
//     }
// }
// Main();
