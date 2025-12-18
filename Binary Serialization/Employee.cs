namespace Binary.Serialization;

[Serializable]
internal class Employee(string name)
{

    string EmployeeName { get; set; } = name;

}
