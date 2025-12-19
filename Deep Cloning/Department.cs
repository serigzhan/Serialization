using System.Text.Json;

namespace Deep.Cloning;

public class Department(string DepartmentName)
{

    public string DepartmentName { get; set; } = DepartmentName;

    public List<Employee> Employees { get; set; } = [];

    public void Add(Employee employee)
    {

        Employees.Add(employee);

    }

    public Department DeepCopy()
    {

        string jsonString = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<Department>(jsonString);

    }

}
