using System;

bool running = true;

while (running)
{
    Console.WriteLine("You have reached the main menu. Navigate the menu by inputting a number.");
    Console.WriteLine("0. Quit Program");
    Console.Write("Input a command: ");
    
    switch (Console.ReadLine())
    {
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Unknown command. Please input one of the numbers listed.");
            break;
    }
}