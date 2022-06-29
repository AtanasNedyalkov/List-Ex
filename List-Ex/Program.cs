using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacityOfWagon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                List<string> directions = command.Split().ToList();
                if (directions[0] == "Add")
                {
                    wagons.Add(int.Parse(directions[1]));
                }
                else
                {
                    int passangersToFit = int.Parse(directions[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+passangersToFit<=capacityOfWagon)
                        {
                            wagons[i] += passangersToFit;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in wagons)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
