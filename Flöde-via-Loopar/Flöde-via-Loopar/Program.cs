using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

bool running = true;

while (running)
{
    Console.WriteLine("You have reached the main menu. Navigate the menu by inputting a number.");
    Console.WriteLine("0. Quit program");
    Console.WriteLine("1. Check price (one person)");
    Console.WriteLine("2. Check price (group)");
    Console.WriteLine("3. Repeat text 10 times");
    Console.WriteLine("4. Find the third word");
    Console.Write("Input a command: ");
    
    switch (Console.ReadLine())
    {
        case "0":
        {
            running = false;
            break;
        }
        case "1":
        {
            Console.Write("Please input an age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine(CheckAge(age));
            }
            else
            {
                Console.WriteLine("Invalid age. Please input a number.");
            }
            break;
        }
        case "2":
        {
            Console.Write("Please input the size of the group: ");
            if (int.TryParse(Console.ReadLine(), out int groupSize)) {
                List<string> responses = new List<string>();
                for (int i = 0; i < groupSize; i ++)
                {
                    Console.Write("Please input an age: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        responses.Add(CheckAge(age));
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please only use numbers");
                        break;
                    }
                }
                if (responses.Count == groupSize)
                {
                    Console.WriteLine($"Size of group: {groupSize}");
                    foreach (string response in responses)
                    {
                        Console.WriteLine(response);
                    }  
                }
            }
            else
            {
                Console.WriteLine("Invalid group size. Please input a number");
            }
            break;
        }
        case "3":
        {
            Console.Write("Please input text to be repeated: ");
            string? input = Console.ReadLine();
            if (input != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i + 1}. {input}, ");
                }
            }
            break;
        }
        case "4":
        {
            Console.Write("Please input 3 words or more: ");
            var input = Console.ReadLine();
            if (input != null && input.Split(" ").Length >= 3)
            {
                var third = input.Split(" ")[2];
                Console.WriteLine($"The third word is: {third}");
            }
            break;
        }
        default:
            Console.WriteLine("Unknown command. Please input one of the numbers listed.");
            break;
    }
}

// Takes an int age and returns a string depending on what age group it is
static string CheckAge(int age)
{
    return age switch
    {
        < 20 => "Ungdomspris: 80kr",
        > 64 => "Pensionärspris: 90kr",
        _ => "Standardpris: 120kr",
    };
}