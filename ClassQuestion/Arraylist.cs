using System;
using System.Collections.Generic;

class NumberOperations
{
    private List<int> numbers = new List<int>();

    public void AddValue(int value)
    {
        numbers.Add(value);
        Console.WriteLine($"Added {value} to the list.");
    }

    public void InsertValue(int value, int index)
    {
        if (index >= 0 && index <= numbers.Count)
        {
            numbers.Insert(index, value);
            Console.WriteLine($"Inserted {value} at index {index}.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void RemoveValue(int index)
    {
        if (index >= 0 && index < numbers.Count)
        {
            Console.WriteLine($"Removed {numbers[index]} from index {index}.");
            numbers.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void DisplayCount()
    {
        Console.WriteLine($"The list contains {numbers.Count} values.");
    }

    public void ReverseList()
    {
        numbers.Reverse();
        Console.WriteLine("Reversed the list.");
    }

    public void SortList()
    {
        numbers.Sort();
        Console.WriteLine("Sorted the list.");
    }

    public void ListValues()
    {
        Console.WriteLine("List of values:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"Index {i}: {numbers[i]}");
        }
    }
}
class Arraylist
{
    public static void Main(string[] args)
    {
        NumberOperations operations = new NumberOperations(); // Instance of the helper class
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a value");
            Console.WriteLine("2. Insert a value at a specific index");
            Console.WriteLine("3. Remove a value at a specific index");
            Console.WriteLine("4. Count of values");
            Console.WriteLine("5. Reverse the list");
            Console.WriteLine("6. Sort the list");
            Console.WriteLine("7. List all values");
            Console.WriteLine("8. Exit");

            Console.Write("\nSelect an option (1-8): ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter a value to add: ");
                    int valueToAdd = int.Parse(Console.ReadLine());
                    operations.AddValue(valueToAdd);
                    break;

                case 2:
                    Console.Write("Enter the value to insert: ");
                    int valueToInsert = int.Parse(Console.ReadLine());
                    Console.Write("Enter the index to insert at: ");
                    int indexToInsert = int.Parse(Console.ReadLine());
                    operations.InsertValue(valueToInsert, indexToInsert);
                    break;

                case 3:
                    Console.Write("Enter the index to remove the value from: ");
                    int indexToRemove = int.Parse(Console.ReadLine());
                    operations.RemoveValue(indexToRemove);
                    break;

                case 4:
                    operations.DisplayCount();
                    break;

                case 5:
                    operations.ReverseList();
                    break;

                case 6:
                    operations.SortList();
                    break;

                case 7:
                    operations.ListValues();
                    break;

                case 8:
                    continueProgram = false;
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
