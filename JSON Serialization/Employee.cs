using System.Text.Json.Serialization;

namespace JSON.Serialization;

[Serializable]
public class Employee(string EmployeeName)
{

    [JsonPropertyName("name")]
    public string EmployeeName { get; set; } = EmployeeName;

}
