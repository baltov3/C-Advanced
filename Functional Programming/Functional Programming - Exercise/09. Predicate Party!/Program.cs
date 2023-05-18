using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.PredicateParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();
            while (command != "Party!")
            {
                if (guests.Count == 0)
                {
                    break;
                }

                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];
                string property = cmdArgs[1];

                Predicate<string> predicate = x => true;

                if (action == "Remove")
                {
                    if (property == "StartsWith")
                    {
                        predicate = x => x.StartsWith(cmdArgs[2]);
                    }
                    else if (property == "EndsWith")
                    {
                        predicate = x => x.EndsWith(cmdArgs[2]);
                    }
                    else if (property == "Length")
                    {
                        int length = int.Parse(cmdArgs[2]);
                        predicate = x => x.Length == length;
                    }

                    guests.RemoveAll(predicate);
                }
                else if (action == "Double")
                {
                    if (property == "StartsWith")
                    {
                        predicate = x => x.StartsWith(cmdArgs[2]);
                    }
                    else if (property == "EndsWith")
                    {
                        predicate = x => x.EndsWith(cmdArgs[2]);
                    }
                    else if (property == "Length")
                    {
                        int length = int.Parse(cmdArgs[2]);
                        predicate = x => x.Length == length;
                    }

                    Action<List<string>, Predicate<string>, int> doubleGuest = DoubleGuest;
                    doubleGuest(guests, predicate, 0);
                }

                command = Console.ReadLine();
            }

            if (guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static void DoubleGuest(List<string> guests, Predicate<string> predicate, int index)
        {
            if (predicate(guests[index]))
            {
                
                guests.Insert(index, guests[index]);
                index++;
            }

           
            index++;

            if (index < guests.Count)
            {
                DoubleGuest(guests, predicate, index);
            }
        }
    }
}
