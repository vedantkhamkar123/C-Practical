using System;
using System.Collections.Generic;

class Arraylist2
{
    static void Main()
    {
        List<int> numbers = new List<int>();
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
                    numbers.Add(valueToAdd);
                    Console.WriteLine($"Added {valueToAdd} to the list.");
                    break;

                case 2:
                    Console.Write("Enter the value to insert: ");
                    int valueToInsert = int.Parse(Console.ReadLine());
                    Console.Write("Enter the index to insert at: ");
                    int indexToInsert = int.Parse(Console.ReadLine());

                    if (indexToInsert >= 0 && indexToInsert <= numbers.Count)
                    {
                        numbers.Insert(indexToInsert, valueToInsert);
                        Console.WriteLine($"Inserted {valueToInsert} at index {indexToInsert}.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the index to remove the value from: ");
                    int indexToRemove = int.Parse(Console.ReadLine());

                    if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                    {
                        Console.WriteLine($"Removed {numbers[indexToRemove]} from index {indexToRemove}.");
                        numbers.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case 4:
                    Console.WriteLine($"The list contains {numbers.Count} values.");
                    break;

                case 5:
                    numbers.Reverse();
                    Console.WriteLine("Reversed the list.");
                    break;

                case 6:
                    numbers.Sort();
                    Console.WriteLine("Sorted the list.");
                    break;

                case 7:
                    Console.WriteLine("List of values:");
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        Console.WriteLine($"Index {i}: {numbers[i]}");
                    }
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
