using System.Text.Json.Serialization;

namespace JSON.Serialization;

[Serializable]
public class Department(string DepartmentName)
{

    [JsonPropertyName("name")]
    public string DepartmentName { get; set; } = DepartmentName;

    [JsonPropertyName("employees")]
    public List<Employee> Employees { get; set; } = [];

    public void Add(Employee employee)
    {

        Employees.Add(employee);

    }

}
