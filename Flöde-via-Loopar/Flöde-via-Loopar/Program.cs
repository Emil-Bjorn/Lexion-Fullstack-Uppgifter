using System;

bool running = true;

while (running)
{
    Console.WriteLine("You have reached the main menu. Navigate the menu by inputting a number.");
    Console.WriteLine("0. Quit program");
    Console.WriteLine("1. Check age group");
    Console.Write("Input a command: ");
    
    switch (Console.ReadLine())
    {
        case "0":
            running = false;
            break;
        case "1":
            Console.Write("Please input an age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine(CheckAge(age));
            }
            else
            {
                Console.WriteLine("Please provide age as a number.");
            }
            break;
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