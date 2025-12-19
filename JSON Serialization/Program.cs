using System.Text.Json;

namespace JSON.Serialization;

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

        string jsonString = JsonSerializer.Serialize(department);

        File.WriteAllText("department.json", jsonString);

        using (StreamReader reader = new StreamReader("department.json"))
        {
            string json = reader.ReadToEnd();
            Department newDepartment = JsonSerializer.Deserialize<Department>(json);

            Console.WriteLine("New department name: {0}", newDepartment.DepartmentName);
            Console.WriteLine("New first employee name: {0}", newDepartment.Employees[0].EmployeeName);

        }

        Console.ReadLine();

    }
}
