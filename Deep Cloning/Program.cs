using System.Text.Json;

namespace Deep.Cloning;

public class Program
{
    public static void Main()
    {

        Department department = new("Sales");

        Employee employeeOne = new("Maks");
        department.Add(employeeOne);

        Employee employeeTwo = new("Jhon");
        department.Add(employeeTwo);

        Employee employeeThree = new("Sara");
        department.Add(employeeThree);

        var copy = department.DeepCopy();

        copy.DepartmentName = "Marketing";
        copy.Add(new Employee("Ben"));

        Console.WriteLine("Original Department Name: {0}", department.DepartmentName);
        Console.WriteLine("Original Department Employees: {0}", department.Employees.Count);

        Console.WriteLine("Copy Department Name: {0}", copy.DepartmentName);
        Console.WriteLine("Copy Department Employees: {0}", copy.Employees.Count);

    }
}
