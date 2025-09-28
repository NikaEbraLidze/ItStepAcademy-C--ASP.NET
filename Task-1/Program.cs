using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        // Array & Loop Practice Tasks in C#:

        // 1. Print Array Elements
        //     o Create an integer array with 5 numbers and use a for loop to print all the elements.

        // int[] arr = [1, 2, 3, 4];

        // LogInt(arr);

        // 2. Find Maximum Element
        //     o Write a program that finds the largest number in an array.
        // int[] arr = [1, 20, 3, 4];
        // int maxNum = arr[0];

        // findMaxElement(arr, maxNum);

        // 3. Find Minimum Element
        //     o Write a program that finds the smallest number in an array.

        // int[] arr = [1, 20, 3, 4];
        // int minNum = arr[0];

        // findMinElement(arr, minNum);


        // 4. Sum of Array Elements
        //     o Calculate and print the sum of all elements in an integer array.

        // int[] arr = [1, 20, 3, 4];
        // int sumAllElements = 0;

        // sumElements(arr, sumAllElements);


        // 5. Reverse Array
        //     o Print the elements of an array in reverse order using a for loop.

        // int[] arr = [1, 2, 3, 4];

        // LogIntReverse(arr);

        // 6. Count Even and Odd Numbers
        //     o Given an integer array, count how many even and odd numbers are present.

        // int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        // int evenNums = CountEven(arr);
        // int oddNums = CountOdd(arr);

        // Console.WriteLine($"Even numbers: {evenNums}");
        // Console.WriteLine($"Odd numbers: {oddNums}");

        // 7. Search Element in Array
        //     o Ask the user for a number and check if it exists in the array (linear search).

        // int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        // int number = GetUserInput("Enter a number: ");
        // bool exists = ContainsNumber(arr, number);

        // if (exists)
        //     Console.WriteLine("Number exists in arr");
        // else
        //     Console.WriteLine("Number doesn't exist in arr");


        // 8. Copy Array
        //     o Copy all the elements of one array into another using a loop.

        // int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // int[] copyArr = new int[arr.Length];

        // CopyArrToArr(arr, copyArr);

        // 9. Second Largest Number
        //     o Find the second largest element in an array without sorting.

        // int[] arr = [1, 20, 3112, 412, 345, 226, 7, 8, 9435, 10];
        // (int largest, int secondLargest) = FindTwoLargest(arr);

        // Console.WriteLine($"Largest number: {largest}");
        // Console.WriteLine($"Second largest number: {secondLargest}");

        // Console.Write(secLargNum);

        // 10. Frequency of Elements
        //     · Print how many times each element appears in the array.

        // int[] arr = [1, 20, 7, 412, 7, 226, 7, 8, 1, 20];
        // int[,] matrix = new int[2, arr.Length];

        // int filled = 0;

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (AlreadyCounted(matrix, filled, arr[i]))
        //         continue;


        //     int count = CountOccurrences(arr, arr[i]);

        //     AddToMatrix(matrix, ref filled, arr[i], count);
        // }

        // PrintMatrix(matrix, filled);




        // 🔹 10 Middle-Level Array & Loop Exercises (C#)

        // 1. Array Rotation
        // o Rotate the elements of an array to the left or right by a given number of positions.

        // int[] arr = [1, 20, 7, 412, 7, 11111, 226, 7, 8, 1, 20];

        // if (arr.Length % 2 == 0)
        // {
        //     ChangeElementsIndex(arr.Length / 2, arr);
        // }
        // else
        // {
        //     ChangeElementsIndex((arr.Length - 1) / 2, arr);
        // }

        // PrintArr(arr);


        // 2. Sort Array Without Built-in Sort
        // o Implement a sorting algorithm (like Bubble Sort or Selection Sort) to sort the array in ascending order.

        // int[] arr = { 5, 2, 9, 1, 5, 6 };

        // for (int i = 0; i < arr.Length - 1; i++)
        // {
        //     int minElementIndex = i;
        //     int minElement = arr[i];

        //     GetMinElement(arr, minElement, minElementIndex)

        //     int temp = arr[i];
        //     arr[i] = arr[minElementIndex];
        //     arr[minElementIndex] = temp;
        // }

        // PrintArr(arr);

        // 3. Remove Duplicates
        // o Remove duplicate elements from an array and print the unique elements.

        // int[] arr = { 1, 2, 3, 2, 4, 1, 5 };
        // int[] unique = GetUniqueElements(arr, out int uniqueCount);

        // PrintArray(unique, uniqueCount);

        // 4. Merge Two Arrays
        // o Merge two sorted arrays into one sorted array (without using Array.Sort).

        // 5. Insert Element in Array
        // o Insert a new element at a specific position in the array (shifting elements as needed).

        // 6. Delete Element from Array
        // o Delete a specific element from an array (shifting elements left to fill the gap).

        // 7. Find Pairs with Given Sum
        // o Find and print all pairs of numbers in an array whose sum equals a target value.

        // 8. Check if Array is Palindrome
        // o Determine if the array reads the same forward and backward.

        // 9. Find Missing Number
        // o Given an array containing numbers from 1 to N with one missing, find the missing number.

        // 10. Count Consecutive Duplicates
        // · Find the element with the longest consecutive repetition (e.g., in [1,1,2,2,2,3] → 2 appears 3 times in a row).




    }


    static void LogInt(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i]);
    }

    static void LogIntReverse(int[] arr)
    {
        for (int i = arr.Length; i > 0; i--)
            Console.WriteLine(arr[i]);
    }

    static void findMaxElement(int[] arr, int maxNum)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (maxNum < arr[i])
                maxNum = arr[i];
        }
    }

    static void findMinElement(int[] arr, int minNum)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (minNum > arr[i])
                minNum = arr[i];
        }
    }

    static void sumElements(int[] arr, int sum)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
    }

    static int CountEven(int[] arr)
    {
        int count = 0;
        foreach (var num in arr)
        {
            if (num % 2 == 0) count++;
        }
        return count;
    }

    static int CountOdd(int[] arr)
    {
        int count = 0;
        foreach (var num in arr)
        {
            if (num % 2 != 0) count++;
        }
        return count;
    }

    static int GetUserInput(string message)
    {
        Console.Write(message);
        bool valid = int.TryParse(Console.ReadLine(), out int result);

        if (!valid)
        {
            Console.WriteLine("Invalid input, defaulting to 0.");
            return 0;
        }

        return result;
    }

    static bool ContainsNumber(int[] arr, int target)
    {
        foreach (var num in arr)
        {
            if (num == target)
                return true;
        }
        return false;
    }


    static void CopyArrToArr(int[] arrOne, int[] arrTwo)
    {
        for (int i = 0; i < arrOne.Length; i++)
        {
            arrTwo[i] = arrOne[i];
            Console.WriteLine($"Arr: {arrOne[i]}    Copy: {arrTwo[i]}");
        }
    }

    static (int largest, int secondLargest) FindTwoLargest(int[] arr)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (secondLargest < num && largest > num)
            {
                secondLargest = num;
            }
        }

        return (largest, secondLargest);
    }


    static bool AlreadyCounted(int[,] matrix, int filled, int value)
    {
        for (int k = 0; k < filled; k++)
        {
            if (matrix[0, k] == value)
                return true;
        }
        return false;
    }

    static int CountOccurrences(int[] arr, int value)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item == value) count++;
        }
        return count;
    }

    static void AddToMatrix(int[,] matrix, ref int filled, int value, int count)
    {
        matrix[0, filled] = value;
        matrix[1, filled] = count;
        filled++;
    }

    static void PrintMatrix(int[,] matrix, int filled)
    {
        for (int i = 0; i < filled; i++)
        {
            Console.WriteLine($"{matrix[0, i]} - {matrix[1, i]}");
        }
    }

    static void ChangeElementsIndex(int length, int[] arr)
    {
        for (int i = 0; i < length , i++)
        {
            int a = arr[i];
            int b = arr[arr.Length - 1 - i];

            arr[i] = b;
            arr[arr.Length - 1 - i] = a;

        }
    }

    static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}  ");
        }
    }

    static void GetMinElement(int[] arr, int minElement, int minElementIndex)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minElement)
            {
                minElement = arr[i];
                minElementIndex = i;
            }
        }
    }

    static int[] GetUniqueElements(int[] arr, out int uniqueCount)
    {
        int[] unique = new int[arr.Length];
        uniqueCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!ExistsInArray(unique, uniqueCount, arr[i]))
            {
                unique[uniqueCount] = arr[i];
                uniqueCount++;
            }
        }

        return unique;
    }

    static bool ExistsInArray(int[] arr, int length, int value)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == value) return true;
        }
        return false;
    }

    static void PrintArray(int[] arr, int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

}


