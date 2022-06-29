using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] tokens = command.Split();
                int indexChecker = int.Parse(tokens[1]);
                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Insert")
                {
                    if (indexChecker>=0 && indexChecker<numbers.Count)
                    {
                        int element = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    if (indexChecker >= 0 && indexChecker < numbers.Count)
                    {
                        
                        numbers.Remove(indexChecker);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (tokens[0] == "Shift")
                {
                    string direction = tokens[1];
                    int count = int.Parse(tokens[2]);
                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0,numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
