using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] directions = command.Split();
                int element = int.Parse(directions[1]);
                int position = int.Parse(directions[2]);
                if (directions[0] == "Delete")
                {
                    integers.RemoveAll(x => x == element);
                }
                else if (directions[0] == "Insert")
                {
                    integers.Insert(position,element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",integers));
        }
    }
}
