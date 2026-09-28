using System;

class Program
{
    static void Main()
    {
        // Генератор з фіксованим зерном Seed = 24
        Random rnd = new Random(24);

        Console.WriteLine("=== 1. МАСИВ (20 чисел в діапазоні [-9; 9]) ===");
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-9, 10); // Верхня межа 10, щоб включити 9
        }
        PrintArray(array);

        Console.WriteLine("\n=== 2. КРИТЕРІЙ: елементи, що більші за 2 ===");
        Console.Write("Елементи > 2: ");
        int count = 0;
        foreach (int item in array)
        {
            if (item > 2)
            {
                Console.Write(item + " ");
                count++;
            }
        }
        Console.WriteLine($"\nКількість таких елементів: {count}");

        Console.WriteLine("\n=== 4. ПЕРЕСТАНОВКА: перша й друга половини місцями ===");
        int half = array.Length / 2;
        for (int i = 0; i < half; i++)
        {
            int temp = array[i];
            array[i] = array[i + half];
            array[i + half] = temp;
        }
        PrintArray(array);

        Console.WriteLine("\n=== 5. МАТРИЦЯ (4 x 5, діапазон [-9; 9]) ===");
        int[,] matrix = new int[4, 5];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = rnd.Next(-9, 10);
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

