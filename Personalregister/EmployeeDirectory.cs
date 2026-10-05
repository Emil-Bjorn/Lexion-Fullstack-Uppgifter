using System;

namespace Personalregister;

public class EmployeeDirectory
{
    public List<Employee> Employees {get; set;}
    
    public EmployeeDirectory(List<Employee> employees)
    {
        Employees = employees;
    }
}
