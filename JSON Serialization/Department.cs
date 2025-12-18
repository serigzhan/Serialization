namespace XML.Serialization;

internal class Department(string name)
{

    public string DepartmentName { get; set; } = name;

    public List<Employee> Employees { get; set; } = [];

    public void Add(Employee employee)
    {

        Employees.Add(employee);

    }

}
