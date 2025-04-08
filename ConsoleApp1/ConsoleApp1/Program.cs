using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть програму:");
        Console.WriteLine("1 - Другий найбільший елемент масиву");
        Console.WriteLine("2 - Сортування двовимірного масиву за зростанням");
        Console.WriteLine("3 - Видалення елемента за індексом");
        Console.WriteLine("4 - Сума елементів по діагоналі");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                FindSecondLargest();
                break;
            case 2:
                Sort2DArray();
                break;
            case 3:
                RemoveElement();
                break;
            case 4:
                SumDiagonal();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }

    static void FindSecondLargest()
    {
        int[] arr = { 5, 7, 2, 9, 3 };
        Array.Sort(arr);
        Console.WriteLine($"Другий найбільший елемент: {arr[arr.Length - 2]}");
    }

    static void Sort2DArray()
    {
        int[,] arr = { { 9, 3, 7 }, { 5, 1, 8 }, { 6, 4, 2 } };
        int[] temp = new int[arr.Length];
        int index = 0;

        foreach (int num in arr)
            temp[index++] = num;

        Array.Sort(temp);

        index = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[i, j] = temp[index++];

        Console.WriteLine("Відсортований масив:");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void RemoveElement()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Введіть індекс для видалення: ");
        int indexToRemove = int.Parse(Console.ReadLine());

        if (indexToRemove < 0 || indexToRemove >= arr.Length)
        {
            Console.WriteLine("Невірний індекс.");
            return;
        }

        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
            if (i != indexToRemove)
                newArr[j++] = arr[i];

        Console.WriteLine("Новий масив:");
        foreach (int num in newArr)
            Console.Write(num + " ");
    }

    static void SumDiagonal()
    {
        int[,] arr = { { 2, 4, 6 }, { 3, 5, 7 }, { 8, 1, 9 } };
        int sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
            sum += arr[i, i];

        Console.WriteLine($"Сума діагональних елементів: {sum}");
    }
}
