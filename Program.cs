// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int y = 0; y < numbers.Length; y++)
// if (numbers[y] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int q = 0; q < numbers.Length; q+=2)
//     sum = sum + numbers[q];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// // Задача 37: Найдите произведение пар чисел в одномерном массиве.
// // Парой считаем первый и последний элемент, второй и предпоследний
// // и т.д. Результат запишите в новом массиве.

// int[] MyArr = { 2, 4, 5, 3, 6, 8, 10, 2, 9, 7, 3 };

// Console.WriteLine(String.Join(" ", MyArr));

// int[] NewArr = new int[MyArr.Length / 2];
// int n = MyArr.Length;

// for (int i = 0; i < MyArr.Length / 2; i++)
// {
//     NewArr[i] = MyArr[i] * MyArr[MyArr.Length - 1 - i];
//     Console.WriteLine(String.Join(" ", NewArr));
// }

// {
//     int[] Arr = new int [(MyArr.Length /2)+ 1];
// for (int i =0; i < (MyArr.Length /2); i++ )
// {
// NewArr[i]= MyArr[i]* MyArr[^(i + 1)];
// System.Console.Write($" {NewArr[i]}   ");
// }

// NewArr[MyArr.Length /2] = MyArr[MyArr.Length /2];

// System.Console.WriteLine();

// System.Console.WriteLine(NewArr [MyArr.Length /2]);
// }



// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int a = 0; a < numbers.Length; a++)
// {
//     if (numbers[a] > max)
//         {
//             max = numbers[a];
//         }
//     if (numbers[a] < min)
//         {
//             min = numbers[a];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }