using System;

namespace Personalregister;

public class EmployeeDirectory
{
    public Employee[] Employees {get; set;}
    
    public EmployeeDirectory(Employee[] employees)
    {
        Employees = employees;
    }
}
