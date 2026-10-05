using Personalregister;

EmployeeDirectory directory = new EmployeeDirectory();
bool running = true;

while (running)
{
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. List all employees");
    Console.WriteLine("3. Quit");
    Console.Write("Please select an option: ");
    string? command = Console.ReadLine();

    switch (command)
    {
        case "1": 
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Salary: ");
            string? salaryString = Console.ReadLine();
            if (int.TryParse(salaryString, out int salary) && name != null)
            {
                directory.AddEmployee(new Employee(name, salary));
                Console.WriteLine("Employee sucessfully added to directory!");
            } else
            {
                Console.WriteLine("Please ensure salary is a number.");
            }
            break;
        case "2": 
            foreach (Employee employee in directory.Employees) {
                Console.WriteLine(employee);
            }
            break;
        case "3": 
            Console.WriteLine("Quitting application");
            running = false;
            break;
        default:
            Console.WriteLine("Unknown Command. Please input 1, 2, or 3. ");
            break;
    }
}