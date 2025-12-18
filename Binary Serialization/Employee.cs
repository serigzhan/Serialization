namespace Binary.Serialization;

[Serializable]
internal class Employee(string name)
{

    public string EmployeeName { get; set; } = name;

}
