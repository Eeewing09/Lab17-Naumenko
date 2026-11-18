int[] scores = { 60, 80, 40, 80, 90 };
// int sum = 0;
// foreach (int score in scores)
// {
//     sum += score;
// }
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(scores));
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));

// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountAtLeast(scores, 50));
// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count += 1;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));
// int FindMax(int[] numbers)
// {
//     int max = numbers[0];

//     for (int i = 1; i < numbers.Length; i++)
//     {
//         if (numbers[i] > max)
//         {
//             max = numbers[i];
//         }
//     }

//     return max;
// }
// int FindMin(int[] numbers)
// {
//     int min = numbers[0];
//     for (int j = 0; j < numbers.Length; j++)
//     {
//         if (numbers[j] < min)
//         {
//             min = numbers[j];
//         }
//     }
//     return min;
// }
// Console.WriteLine(FindMax(scores));
// Console.WriteLine(FindMin(scores));
int FindMin(int[] numbers)
{
    int min = numbers[0];

    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
}
Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));