using System;

class Program
{
    static void Main()
    {
        // Array & Loop Practice Tasks in C#:

        // 1. Print Array Elements
        //     o Create an integer array with 5 numbers and use a for loop to print all the elements.

        // int[] arr = [1, 2, 3, 4];

        // for (int i = 0; i < arr.Length; i++)
        //     Console.WriteLine(arr[i]);

        // 2. Find Maximum Element
        //     o Write a program that finds the largest number in an array.
        // int[] arr = [1, 20, 3, 4];
        // int maxNum = arr[0];

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (maxNum < arr[i])
        //         maxNum = arr[i];
        // }

        // 3. Find Minimum Element
        //     o Write a program that finds the smallest number in an array.

        // int[] arr = [1, 20, 3, 4];
        // int minNum = arr[0];

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (minNum > arr[i])
        //         minNum = arr[i];
        // }


        // 4. Sum of Array Elements
        //     o Calculate and print the sum of all elements in an integer array.

        // int[] arr = [1, 20, 3, 4];
        // int sumAllElements = 0;

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     sumAllElements += arr[i];
        // }


        // 5. Reverse Array
        //     o Print the elements of an array in reverse order using a for loop.

        // int[] arr = [1, 2, 3, 4];

        // for (int i = arr.Length; i > 0; i--)
        //     Console.WriteLine(arr[i]);

        // 6. Count Even and Odd Numbers
        //     o Given an integer array, count how many even and odd numbers are present.

        // int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // int oddNums = 0;
        // int evenNums = 0;

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (arr[i] % 2 == 0)
        //     {
        //         evenNums++;
        //     }
        //     else
        //     {
        //         oddNums++;
        //     }
        // }

        // 7. Search Element in Array
        //     o Ask the user for a number and check if it exists in the array (linear search).

        // int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // Console.Write("Enter a Number: ");
        // bool searchNum = int.TryParse(Console.ReadLine(), out int result);
        // if (searchNum)
        // {
        //     bool found = false;
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         if (result == arr[i])
        //             found = true;
        //     }
        //     if (found)
        //         Console.WriteLine("Number exists in arr");
        //     else
        //         Console.WriteLine("Number doesn't exist in arr");
        // }

        // 8. Copy Array
        //     o Copy all the elements of one array into another using a loop.

        // int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // int[] copyArr = new int[arr.Length];

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     copyArr[i] = arr[i];
        //     Console.WriteLine($"Arr: {arr[i]}    Copy: {copyArr[i]}");
        // }

        // 9. Second Largest Number
        //     o Find the second largest element in an array without sorting.

        // int[] arr = [1, 20, 3112, 412, 345, 226, 7, 8, 9435, 10];
        // int secLargNum = 0;
        // int largestNum = 0;//1

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (largestNum < arr[i])
        //     {
        //         largestNum = arr[i];

        //         for (int b = 0; b < arr.Length; b++)
        //         {
        //             if (largestNum > arr[b] && secLargNum < arr[b] && largestNum > secLargNum)
        //             {
        //                 secLargNum = arr[b];
        //             }
        //         }
        //     }
        // }

        // Console.Write(secLargNum);

        // 10. Frequency of Elements
        //     · Print how many times each element appears in the array.

        // int[] arr = [1, 20, 7, 412, 7, 226, 7, 8, 1, 20];
        // int[,] matrix = new int[2, arr.Length];

        // int filled = 0;

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     bool alreadyCounted = false;

        //     for (int k = 0; k < filled; k++)
        //     {
        //         if (matrix[0, k] == arr[i])
        //         {
        //             alreadyCounted = true;
        //             break;
        //         }
        //     }

        //     if (alreadyCounted) continue;

        //     int count = 0;

        //     for (int b = 0; b < arr.Length; b++)
        //     {
        //         if (arr[i] == arr[b])
        //         {
        //             count++;
        //         }
        //     }

        //     matrix[0, filled] = arr[i];
        //     matrix[1, filled] = count;
        //     filled++;
        // }

        // for (int c = 0; c < filled; c++)
        // {
        //     Console.WriteLine($"{matrix[0, c]} - {matrix[1, c]}");
        // }




        // 🔹 10 Middle-Level Array & Loop Exercises (C#)

        // 1. Array Rotation
        // o Rotate the elements of an array to the left or right by a given number of positions.

        // int[] arr = [1, 20, 7, 412, 7, 11111, 226, 7, 8, 1, 20];

        // if (arr.Length % 2 == 0)
        // {
        //     for (int i = 0; i < arr.Length / 2; i++)
        //     {
        //         int a = arr[i];
        //         int b = arr[arr.Length - 1 - i];

        //         arr[i] = b;
        //         arr[arr.Length - 1 - i] = a;
        //     }
        // }
        // else
        // {
        //     for (int i = 0; i < (arr.Length - 1) / 2; i++)
        //     {
        //         int a = arr[i];
        //         int b = arr[arr.Length - 1 - i];

        //         arr[i] = b;
        //         arr[arr.Length - 1 - i] = a;
        //     }
        // }

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     Console.Write($"{arr[i]}  ");
        // }


        // 2. Sort Array Without Built-in Sort
        // o Implement a sorting algorithm (like Bubble Sort or Selection Sort) to sort the array in ascending order.

        // int[] arr = { 5, 2, 9, 1, 5, 6 };

        // for (int i = 0; i < arr.Length - 1; i++)
        // {
        //     int minElementIndex = i;
        //     int minElement = arr[i];

        //     for (int j = i + 1; j < arr.Length; j++)
        //     {
        //         if (arr[j] < minElement)
        //         {
        //             minElement = arr[j];
        //             minElementIndex = j;
        //         }
        //     }

        //     int temp = arr[i];
        //     arr[i] = arr[minElementIndex];
        //     arr[minElementIndex] = temp;
        // }

        // for (int a = 0; a < arr.Length; a++)
        // {
        //     Console.Write($"{arr[a]}  ");
        // }

        // 3. Remove Duplicates
        // o Remove duplicate elements from an array and print the unique elements.

        // int[] arr = { 1, 2, 3, 2, 4, 1, 5 };
        // int[] unique = new int[arr.Length];
        // int uniqueCount = 0;

        // for (int i = 0; i < arr.Length; i++)
        // {
        //     bool exists = false;

        //     for (int j = 0; j < arr.Length; j++)
        //     {
        //         if (arr[i] == unique[j])
        //         {
        //             exists = true;
        //             break;
        //         }
        //     }

        //     if (!exists)
        //     {
        //         unique[uniqueCount] = arr[i];
        //         uniqueCount++;
        //     }
        // }

        // for (int i = 0; i < uniqueCount; i++)
        // {
        //     Console.Write(unique[i] + " ");
        // }

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

}


